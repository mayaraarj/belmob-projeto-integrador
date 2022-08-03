using Belmob.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Belmob.Controllers.PaginaDoCliente
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReagendamentoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();
        [HttpPost]
        public ActionResult<List<Atendimento>> Agendar(Atendimento atendimento, int IdCliente, int IdProfissional, int IdEndereco)
        {
            var cliente = DbSistema.Clientes.Find(IdCliente);
            var profissional = DbSistema.Profissionais.Find(IdProfissional);
            var endereco = DbSistema.Enderecos.Find(IdEndereco);

            atendimento.Data = new DateTime();
            atendimento.Endereco = endereco;
            atendimento.Profissional = profissional;
            atendimento.Cliente = cliente;
            DbSistema.Atendimentos.Add(atendimento);

            DbSistema.SaveChanges();
            return Ok(atendimento);
        }

        [HttpGet]
        public ActionResult<Atendimento> RequererTodosAgendamentos()
        {
            return Ok(DbSistema.Atendimentos.Include(c => c.Endereco).Include(c => c.Cliente).Include(c => c.Profissional).ToList());
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
        public ActionResult<Atendimento> SubstituirDadosDoAgendamentoPelaId(int Id, Atendimento atendimento)
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
