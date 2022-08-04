﻿using Belmob.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Belmob.Controllers.PaginaDoProfissional
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentosDisponiveisController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();
        [HttpGet]
        [Authorize(Roles = "Administrador, Profissional")]
        public ActionResult<Atendimento> RequererTodosAtendimentosDisponiveis()
        {
            if (DbSistema.Atendimentos.Any(u => u.Profissional == null))
            {
                return Ok(DbSistema.Atendimentos.Include(c => c.Endereco).Include(c => c.Cliente).Include(c => c.Profissional).Where(u => u.Profissional == null).ToList());
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPut("{Id}")]
        [Authorize(Roles = "Profissional")]
        public ActionResult<Atendimento> AceitarAgendamento(int Id, Atendimento atendimento)
        {
            if (atendimento == null)
                return BadRequest();

            if (atendimento.Id != Id)
                return BadRequest();

            var resultado = DbSistema.Atendimentos.Find(Id);

            if (resultado == null)
                return NotFound();

            if (DbSistema.Atendimentos.Any(u => u.Id != Id))
                return Conflict();

            resultado.Data = atendimento.Data;
            resultado.TipoDeServico = atendimento.TipoDeServico;
            resultado.TipoDePagamento = atendimento.TipoDePagamento;
            resultado.CupomDesconto = atendimento.CupomDesconto;
            resultado.Cliente = atendimento.Cliente;
            resultado.Profissional = atendimento.Profissional;
            resultado.Endereco = atendimento.Endereco;

            DbSistema.SaveChanges();
            return Ok(atendimento);
        }
    }
}
