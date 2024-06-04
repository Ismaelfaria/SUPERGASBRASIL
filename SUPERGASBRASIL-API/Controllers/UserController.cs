using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _user;

        public UserController(IUserService user)
        {
            _user = user;
        }

        /// <summary>
        /// Cria um usuario de usuario.
        /// </summary>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarRegistro([FromForm] User user)
        {
            try
            {
                var create = _user.Create(user);

                return CreatedAtAction(nameof(BuscaUsuariosPorNome), new { name = create.Username }, create);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar produto {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar todos os usuarios.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet]
        public IActionResult BuscarTodosUsuarios()
        {
            try
            {
                var produt = _user.FindAll();

                return Ok(produt);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"usuarios não encontrados, Erro na operação {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar os usuarios pelo nome.
        /// </summary>
        ///
        /// <response code="404">Seu o item não for encontrado</response> 
        [HttpGet("{name}")]
        public IActionResult BuscaUsuariosPorNome(string name)
        {
            try
            {
                var user = _user.FindByUserName(name);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"usuarios não encontrado, Erro na operação {ex.Message}");
            }
        }

        /// <summary>
        /// Deletar um usuario pelo ID.
        /// </summary>
        ///
        /// <response code="500">Se o item não for deletado</response> 
        [HttpDelete]
        public IActionResult DeletarRegistro(Guid id)
        {
            try
            {
                _user.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"usuarios não encontrado, Erro na operação {ex.Message}");
            }
        }

    }
}
