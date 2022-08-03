using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Belmob.Controllers.Cliente
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovoAgendamentoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();
        [HttpPost]
        public ActionResult<List<Atendimento>> Agendar(Atendimento atendimento, int IdCliente, int IdEndereco)
        {
            var cliente = DbSistema.Clientes.Find(IdCliente);
            var endereco = DbSistema.Enderecos.Find(IdEndereco);

            atendimento.Data = new DateTime();
            atendimento.Cliente = cliente;
            atendimento.Endereco = endereco;
            DbSistema.Atendimentos.Add(atendimento);

            DbSistema.SaveChanges();
            return Ok(atendimento);
        }

        [HttpGet]
        public ActionResult<Atendimento> RequererTodosAgendamentos()
        {
            // return OK(DbSistema.Atendimentos.Include(c => c.Enderecos).Include(c => c.Clientes).Include(c => c.Profissionais).AsNoTracking().ToList());
            return Ok(DbSistema.Atendimentos.Include(c => c.Endereco).Include(c => c.Cliente).ToList());
        }

        [HttpGet("{Id}")]
        public ActionResult<Atendimento> RequererAgendamentoPelaId(int Id)
        {
            var resultado = DbSistema.Atendimentos.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }
        [HttpDelete("{Id}")]
        public ActionResult<Atendimento> DeletarAgendamentoPelaId(int Id)
        {
            var resultado = DbSistema.Atendimentos.Find(Id);

            if (resultado == null)
                return NotFound();

            DbSistema.Atendimentos.Remove(resultado);
            DbSistema.SaveChanges();
            return Ok(resultado);
        }

        [HttpPut("{Id}")]
        public ActionResult<Atendimento> SubstituirDadosDeUmAgendamentoPelaId(int Id, Atendimento atendimento)
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
            resultado.Endereco = atendimento.Endereco;

            DbSistema.SaveChanges();
            return Ok(atendimento);
        }
    }
}
