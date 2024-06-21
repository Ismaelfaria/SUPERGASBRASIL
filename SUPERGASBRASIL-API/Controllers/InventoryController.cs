using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Controllers
{
    [Authorize(Roles = "Admin, Secretaria")]
    [Route("api/Inventario")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inv;

        public InventoryController(IInventoryService inv)
        {
            _inv = inv;
        }

        /// <summary>
        /// Cria um registro de Inventario.
        /// </summary>
        /// <returns>Um novo inventario foi criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarInventario([FromForm] Inventory_InputModel inv)
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
        [HttpGet("/buscar-inventarios")]
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
        [HttpGet("/buscar-inventario-id/{id}")]
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
