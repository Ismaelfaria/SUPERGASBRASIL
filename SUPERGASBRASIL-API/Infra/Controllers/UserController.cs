﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;

namespace SUPERGASBRASIL_API.Infra.Controllers
{
    [Authorize(Roles = "Admin, Secretaria")]
    [Route("api/Usuarios")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _user;
        public readonly IMapper _mapper;
        public UserController(
            IUserService user,
            IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        /// <summary>
        /// Cria um usuario de usuario.
        /// </summary>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult CriarRegistro([FromForm] User_InputModel user)
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
        [HttpGet("/buscar-usuarios")]
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
        [HttpGet("/buscar-usuarios-nome/{name}")]
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
        /// <response code="400">Se o item não for deletado</response> 
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
                return StatusCode(400, $"Request Error: {ex.Message}");
            }
        }
    }
}
