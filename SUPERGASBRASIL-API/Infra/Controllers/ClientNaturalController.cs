using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;

namespace SUPERGASBRASIL_API.Infra.Controllers
{
    [Authorize(Roles = "Admin, Secretaria")]
    [ApiController]
    [Route("api/Cliente/Fisico")]

    public class ClientNaturalController : ControllerBase
    {
        private readonly IClientNaturalService client;
        private readonly IMapper mapper;

        public ClientNaturalController(
            IClientNaturalService client,
            IMapper mapper)
        {
            this.client = client;
            this.mapper = mapper;
        }

        /// <summary>
        /// Cria um registro de Cliente Fisico.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     POST 
        ///     {
        ///        "nome": "String",
        ///        "Data": "13/05/2000",
        ///        "CPF": "333666999-60",
        ///     }
        ///
        /// </remarks>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarClientFisico([FromForm] ClientNatural_InputModel clientEntity)
        {
            try
            {
                var create = client.CreateClientNatural(clientEntity);

                return CreatedAtAction(nameof(BuscarCpf), new { cpf = create.CPF }, create);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar client {ex.Message}");
            }
        }

        ///<summary>
        /// Buscar todos os Clientes.
        /// </summary>
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("buscar-todos-clientes")]
        public IActionResult BuscarTodosClientes()
        {
            try
            {
                var clientAll = client.FindAll();

                return Ok(clientAll);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Clientes não encontrados, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Buscar os Clientes pelo nome.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("nomeCliente/{name}")]
        public IActionResult BuscarNome(string name)
        {
            try
            {
                var clientName = client.FindByName(name);

                return Ok(clientName);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Buscar os Clientes pelo CPF.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("cpf/{cpf}")]
        public IActionResult BuscarCpf(string cpf)
        {
            try
            {
                var clientCpf = client.FindByCpf(cpf);

                return Ok(clientCpf);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Atualizar um registro de Cliente.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     PUT 
        ///     {
        ///        "cpf": "2516...",
        /// 
        ///        "nome": "String",
        ///        "Data": "13/05/2000",
        ///        "CPF": "333666999-60",
        ///     }
        ///
        /// </remarks>
        /// <returns>Um novo item atualizado</returns>
        /// <response code="201">Retorna o novo item atualizado</response>
        /// <response code="400">Se o item não for atualizado</response> 
        [HttpPut]
        public IActionResult AtualizarRegistro([FromForm] ClientNatural_InputModel clientEntity, string cpf)
        {
            try
            {
                client.UpdateClientNatural(cpf, clientEntity);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Request Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletar o Clientes pelo ID.
        /// </summary>
        ///
        /// <response code="400">Se o item não for deletado</response> 
        [HttpDelete]
        public IActionResult DeletarRegistro(Guid id)
        {
            try
            {
                client.DeleteClientNatural(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"Request Error: {ex.Message}");
            }
        }
    }
}
