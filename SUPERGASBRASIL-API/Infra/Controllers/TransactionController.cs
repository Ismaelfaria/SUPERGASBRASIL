﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Domain.Enum;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Infra.Controllers
{
    [Authorize(Roles = "Admin, Secretaria")]
    [Route("api/Transacao")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _tran;
        public TransactionController(ITransactionService tra)
        {
            _tran = tra;
        }

        /// <summary>
        /// Cria uma transação.
        /// </summary>
        /// <returns>Um novo item criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="500">Se o item não for criado</response> 
        [HttpPost]
        public IActionResult TransactionProcess([FromForm] Guid IdInventory, ETransactionINorOUT type, int quantity)
        {
            try
            {
                _tran.ProcessTransaction(IdInventory, type, quantity);

                return StatusCode(200, $"Operação concluida");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Operação não concluida, Erro ao criar produto {ex.Message}");
            }
        }
        /// <summary>
        /// Buscar todos as transações.
        /// </summary>
        ///
        /// <response code="404">Se o item não for encontrado</response> 
        [HttpGet("/buscar-transações")]
        public IActionResult BuscarTodasTransacoes()
        {
            try
            {
                var produt = _tran.FindAll();

                return Ok(produt);
            }
            catch (Exception ex)
            {
                return StatusCode(404, $"transações não encontrados, Erro na operação {ex.Message}");
            }
        }
    }
}
