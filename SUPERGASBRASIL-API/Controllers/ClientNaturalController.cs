using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Controllers
{
    [ApiController]
    [Route("api/ClientFisico")]
    
    public class ClientNaturalController : ControllerBase
    {
        private readonly IClientNaturalService client;
        private readonly IMapper mapper;

        public ClientNaturalController(IClientNaturalService client, IMapper mapper)
        {
            this.client = client;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult CriarClientFisico([FromForm] ClientNatural_InputModel clientEntity)
        {
            try
            {
                var create = client.CreateClientNatural(clientEntity);

                return CreatedAtAction(nameof(BuscarCpf), new {cpf = create.CPF}, create );
            } catch (ValidationException ex)
            {
                return BadRequest(new { errors = ex.Errors.Select(e => e.ErrorMessage) });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar client {ex.Message}");
            }
        }
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

        [HttpGet("{name}")]
        public IActionResult BuscarNome(string name)
        {
            try { 
            var clientName = client.FindByName(name);

                return Ok(clientName);
            }catch (Exception ex)
            {
                return StatusCode(404, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }

        [HttpGet("{cpf}")]
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
                return StatusCode(500, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }
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
                return StatusCode(500, $"Cliente não encontrado, Erro na operação {ex.Message}");
            }
        }
    }
}
