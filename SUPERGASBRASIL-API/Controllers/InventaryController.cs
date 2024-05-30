using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services;

namespace SUPERGASBRASIL_API.Controllers
{
    [Route("api/Inventary")]
    [ApiController]
    public class InventaryController : ControllerBase
    {
        private readonly InventoryService _inv;

        public InventaryController(InventoryService inv)
        {
            this._inv = inv;
        }


        /// <summary>
        /// Cria um registro de Inventario.
        /// </summary>
        /// <returns>Um novo inventario foi criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarInventario([FromForm] Inventory inv)
        {
            try
            {
                var create = _inv.CreateInventory(inv);

                return CreatedAtAction(nameof(BuscaInventariosPorId), new { id = create.IdInventory }, create);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar inventario {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar todos os Inventarios.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet]
        public IActionResult BuscarTodosInventarios()
        {
            try
            {
                var inv = _inv.FindAll();

                return Ok(inv);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Inventarios não encontrados, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar inventario pelo ID.
        /// </summary>
        ///
        /// <response code="404">Seu o item não for encontrado</response> 
        [HttpGet("{name}")]
        public IActionResult BuscaInventariosPorId(Guid id)
        {
            try
            {
                var produt = _inv.FindByIdInventory(id);

                return Ok(produt);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"Inventario não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Atualiza registro de um Inventario.
        /// </summary>
        /// <returns>Um novo item atualizado</returns>
        /// <response code="201">Retorna o novo item atualizado</response>
        /// <response code="500">Se o item não foi atualizado</response>
        [HttpPut]
        public IActionResult AtualizarRegistro([FromForm] Guid Id, int Quantidade)
        {
            try
            {
                _inv.UpdateInventory(Id, Quantidade);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Inventary não encontrado, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Deletar o inventario pelo ID.
        /// </summary>
        ///
        /// <response code="500">Se o item não for deletado</response> 
        [HttpDelete]
        public IActionResult DeletarInventario(Guid id)
        {
            try
            {
                _inv.DeleteInventory(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Inventario não encontrado, Erro na operação {ex.Message}");
            }
        }
    }
}
