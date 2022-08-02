using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;
using Microsoft.AspNetCore.Authorization;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        // Acredito que esse método deva ser um pedido de atendimento e não um cadastro de atendimento em si. Pra ser de fato um cadastro de atendimento,
        // a lógica deve abarcar o "match" da profissional
        [HttpPost]
        [Authorize(Roles = "Usuario")]
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
        [Authorize]
        public ActionResult<List<Atendimento>> ListarAtendimentos()
        {
            return Ok(DbSistema.Atendimentos.ToList());
        }

        [HttpGet("{id}")]
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
