using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Controllers
{
    [Route("api/ClientJuridico")]
    [ApiController]
    public class ClientJuridicoController : ControllerBase
    {
        private readonly IClientLegalService client;
        private readonly IMapper mapper;

        public ClientJuridicoController(IClientLegalService client, IMapper mapper)
        {
            this.client = client;
            this.mapper = mapper;
        }

        /// <summary>
        /// Cria um registro no banco de dados.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     POST 
        ///     {
        ///        "nome": "String",
        ///        "tipoDeEmpresa": "IsmaelFit",
        ///        "tipoDeEmpresa": "MEI",
        ///        "Endereço": "Rua bla bla",
        ///        "cnpj": "22325325-0",
        ///        "contato": "2198056-6602",
        ///     }
        ///
        /// </remarks>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarClientFisico([FromForm] ClientLegal_InputModel clientEntity)
        {
            try
            {
                var create = client.CreateClientLegal(clientEntity);

                return CreatedAtAction(nameof(BuscarCnpj), new { cnpj = create.TaxIdentificationNumberCNPJ }, create);
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
        /// <summary>
        /// Buscar todos os Clientes/Empresas.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet]
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
        /// Buscar os Clientes/Empresas pelo nome.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("{name}")]
        public IActionResult BuscarNomeDaEmpresa(string name)
        {
            try
            {
                var clientName = client.FindByCompanyName(name);

                return Ok(clientName);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar os Clientes/Empresas pelo CNPJ.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("{cnpj}")]
        public IActionResult BuscarCnpj(string cnpj)
        {
            try
            {
                var clientCpf = client.FindByCnpj(cnpj);

                return Ok(clientCpf);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Atualiza um registro no banco de dados.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     PUT 
        ///     {
        ///        "nome": "String",
        ///        "tipoDeEmpresa": "IsmaelFit",
        ///        "tipoDeEmpresa": "MEI",
        ///        "Endereço": "Rua bla bla",
        ///        "cnpj": "22325325-0",
        ///        "contato": "2198056-6602",
        ///     }
        ///
        /// </remarks>
        /// <returns>Um novo item atualizado</returns>
        /// <response code="201">Retorna o novo item atualizado</response>
        /// <response code="500">Se o item não foi atualizado</response> 
        [HttpPut]
        public IActionResult AtualizarRegistro([FromForm] ClientLegal_InputModel clientEntity, string cnpj)
        {
            try
            {
                client.UpdateClientLegal(cnpj, clientEntity);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Deletar o Clientes/Empresas pelo ID.
        /// </summary>
        ///
        /// <response code="500">Se o item não for deletado</response> 
        [HttpDelete]
        public IActionResult DeletarRegistro(Guid id)
        {
            try
            {
                client.DeleteClientLegal(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }
    }
}
