using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;

namespace SUPERGASBRASIL_API.Infra.Controllers
{
    [Authorize(Roles = "Admin, Secretaria")]
    [Route("api/Funcionario")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employee;
        private readonly IMapper mapper;

        public EmployeeController(
            IEmployeeService employee,
            IMapper mapper)
        {
            this.employee = employee;
            this.mapper = mapper;
        }

        /// <summary>
        /// Cria um registro de Funcionario.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     POST 
        ///     {
        ///        "nome": "ismael",
        ///        "cpf": "201201201-00",
        ///        "dataDeNascimento": "00/00/0000",
        ///        "Cargo": "Gerente",
        ///        "dataDeEntradaNaEmpresa": "00/00/0000"
        ///     }
        ///
        /// </remarks>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarFuncionario([FromForm] Employees_InputModel employees_InputModel)
        {
            try
            {
                var create = employee.CreateEmployee(employees_InputModel);

                return CreatedAtAction(nameof(BuscarFuncionarioPorCpf), new { cpf = create.Cpf }, create);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar funcionario {ex.Message}");
            }
        }

        /// <summary>
        /// Buscar todos os Funcionarios.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("/buscar-funcionarios")]
        public IActionResult BuscarTodosFuncionarios()
        {
            try
            {
                var employeeAll = employee.FindAll();

                return Ok(employeeAll);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Funcionario não encontrados, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Buscar os Funcionarios pelo nome.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("/buscar-funcionario-nome/{name}")]
        public IActionResult BuscarNomeDoFuncionario(string name)
        {
            try
            {
                var clientName = employee.FindByName(name);

                return Ok(clientName);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Funcionario não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Buscar os Funcionarios pelo CPF.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("/buscar-funcionario-cpf-{cpf}")]
        public IActionResult BuscarFuncionarioPorCpf(long cpf)
        {
            try
            {
                var employeeCpf = employee.FindByCpf(cpf);

                return Ok(employeeCpf);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Funcionario não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Atualiza registro de um funcionario.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     PUT 
        ///     {
        ///        "cpf": "201201201-00",
        /// 
        ///        "nome": "ismael",
        ///        "cpf": "201201201-00",
        ///        "dataDeNascimento": "00/00/0000",
        ///        "Cargo": "Gerente",
        ///        "dataDeEntradaNaEmpresa": "00/00/0000"
        ///     }
        ///
        /// </remarks>
        /// <returns>Um novo item atualizado</returns>
        /// <response code="201">Retorna o novo item atualizado</response>
        /// <response code="400">Se o item não foi atualizado</response> 
        [HttpPut]
        public IActionResult AtualizarRegistro([FromForm] Employees_InputModel employeei, long cpf)
        {
            try
            {
                employee.UpdateEmployee(cpf, employeei);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Request Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletar o Funcionario pelo ID.
        /// </summary>
        ///
        /// <response code="400">Se o item não for deletado</response> 
        [HttpDelete]
        public IActionResult DeletarRegistro(Guid id)
        {
            try
            {
                employee.DeleteEmployee(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Request Error: {ex.Message}");
            }
        }
    }
}
