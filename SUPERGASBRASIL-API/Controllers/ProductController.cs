using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Controllers
{
    [Authorize(Roles = "Admin, Secretaria")]
    [Route("api/Produto")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService prod;

        public ProductController(IProductService employee)
        {
            this.prod = employee;
        }

        /// <summary>
        /// Cria um registro de Produto.
        /// </summary>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarProduto([FromForm] Product_InputModel produto)
        {
            try
            {
                var create = prod.CreateProduct(produto);

                return CreatedAtAction(nameof(BuscaProdutosPorId), new { id = create.IdProduct }, create);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar produto {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar todos os Produto.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("/buscar-produtos")]
        public IActionResult BuscarTodosProdutos()
        {
            try
            {
                var produt = prod.FindAll();

                return Ok(produt);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"produtos não encontrados, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar os produtos pelo ID.
        /// </summary>
        ///
        /// <response code="404">Seu o item não for encontrado</response> 
        [HttpGet("/buscar-produtos-id/{id}")]
        public IActionResult BuscaProdutosPorId(Guid id)
        {
            try
            {
                var produt = prod.FindByIdProduct(id);

                return Ok(produt);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"produto não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Atualiza registro de um produto.
        /// </summary>
        /// <returns>Um novo item atualizado</returns>
        /// <response code="201">Retorna o novo item atualizado</response>
        /// <response code="500">Se o item não foi atualizado</response>
        [HttpPut]
        public IActionResult AtualizarRegistro([FromForm] Product_InputModel produto, Guid id)
        {
            try
            {
                prod.UpdateProduct(id, produto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"produto não encontrado, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Deletar o produto pelo ID.
        /// </summary>
        ///
        /// <response code="500">Se o item não for deletado</response> 
        [HttpDelete]
        public IActionResult DeletarRegistro(Guid id)
        {
            try
            {
                prod.DeleteProduct(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"produto não encontrado, Erro na operação {ex.Message}");
            }
        }
    }
}
