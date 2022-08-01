using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Atendimento> CadastrarAtendimento(Atendimento atendimento)
        {
            if (atendimento == null)
            {
                return BadRequest();
            }
            else if (DbSistema.Atendimentos.Any(a => a.Data == atendimento.Data))
            {
                return Conflict();
            }
            else
            {
                DbSistema.Atendimentos.Add(atendimento);
                DbSistema.SaveChanges();
                return Ok(atendimento);
            }
        }

        [HttpGet]
        public ActionResult<List<Atendimento>> ListarAtendimentos()
        {
            return Ok(DbSistema.Atendimentos.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Atendimento>> BuscarAtendimentoPeloId(int id)
        {
            var atendimento = DbSistema.Atendimentos.FirstOrDefault(a => a.Id == id);
            if (atendimento == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(atendimento);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Atendimento> DeletarAtendimentoPelaId(int id)
        {
            var atendimento = DbSistema.Atendimentos.Find(id);

            if (atendimento == null)
            {
                return NotFound();
            }
            else
            {
                DbSistema.Atendimentos.Remove(atendimento);
                DbSistema.SaveChanges();
                return Ok(atendimento);
            }
        }

        [HttpPut]
        public ActionResult<Atendimento> SubstituirAtendimentoPelaId(int id, Atendimento atendimento)
        {
            var resultado = DbSistema.Atendimentos.Find(id);

            if (atendimento == null)
            {
                return BadRequest();
            }

            if (atendimento.Id != id || resultado == null)
            {
                return NotFound();
            }

            if (DbSistema.Clientes.Any(a => a.Id != id))
            {
                return Conflict();
            }

            resultado.Data = atendimento.Data;
            resultado.TipoDeServico = atendimento.TipoDeServico;
            resultado.TipoDePagamento = atendimento.TipoDePagamento;
            resultado.CupomDesconto = atendimento.CupomDesconto;
            DbSistema.SaveChanges();
            return Ok(atendimento);
        }
    }
}
