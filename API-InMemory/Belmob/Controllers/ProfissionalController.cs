using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Profissional> PublicarUm(Profissional profissional)
        {
            if (profissional == null)
                return BadRequest();

            if (DbSistema.Profissionais.Any(c => c.CPF == profissional.CPF))
                return Conflict();

            DbSistema.Profissionais.Add(profissional);
            DbSistema.SaveChanges();
            return Ok(profissional);
        }

        [HttpGet]
        public ActionResult<ProfissionalController> RequererTodosAtendimentos()
        {
            return Ok(DbSistema.Profissionais.ToList());
            //return NoContent();
        }

        [HttpGet("{Id}")]
        public ActionResult<ProfissionalController> RequererProfissionalPelaId(int Id)
        {
            var resultado = DbSistema.Profissionais.Find(Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpDelete("{Id}")]
        public ActionResult<Profissional> DeletarProfissionalPelaId(int Id)
        {
            var resultado = DbSistema.Profissionais.Find(Id);

            if (resultado == null)
                return NotFound();

            DbSistema.Profissionais.Remove(resultado);
            DbSistema.SaveChanges();
            return Ok(resultado);
        }


        [HttpPut("{Id}")]
        public ActionResult<Profissional> SubstituirUmPelaId(int Id, Profissional profissional)
        {
            if (profissional == null)
                return BadRequest();

            if (profissional.Id != Id)
                return BadRequest();

            var resultado = DbSistema.Profissionais.Find(Id);

            if (resultado == null)
                return NotFound();

            if (DbSistema.Profissionais.Any(u => u.Id != Id && u.CPF == profissional.CPF))
                return Conflict();

            resultado.Nome = profissional.Nome;
            resultado.Email = profissional.Email;
            resultado.Sexo = profissional.Sexo;
            resultado.Telefone = profissional.Telefone;
            resultado.Celular = profissional.Celular;
            resultado.CPF = profissional.CPF;
            resultado.DataNascimento = profissional.DataNascimento;
            resultado.Banco = profissional.Banco;
            resultado.TipoDeConta = profissional.TipoDeConta;
            resultado.Agencia = profissional.Agencia;
            resultado.ContaComDigito = profissional.ContaComDigito;
            DbSistema.SaveChanges();
            return Ok(profissional);

        }
    }
}
