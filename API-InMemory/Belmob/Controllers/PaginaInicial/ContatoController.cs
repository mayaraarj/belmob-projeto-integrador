using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Contato> PublicarUm(Contato contato)
        {
            if (contato == null)
                return BadRequest();

            DbSistema.Contatos.Add(contato);
            DbSistema.SaveChanges();
            return Ok(contato);
        }
        [HttpGet]
        //[Authorize]
        public ActionResult<Contato> ListarTodosContatos()
        {
            return Ok(DbSistema.Contatos.ToList());
        }

        [HttpGet("{Id}")]
        //[Authorize]
        public ActionResult<Contato> RequererContatosPelaId(int Id)
        {
            var resultado = DbSistema.Contatos.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpDelete("{Id}")]
        //[Authorize]
        public ActionResult<Contato> DeletarContatoPelaId(int Id)
        {
            var resultado = DbSistema.Contatos.Find(Id);

            if (resultado == null)
                return NotFound();

            DbSistema.Contatos.Remove(resultado);
            DbSistema.SaveChanges();
            return Ok(resultado);
        }
    }
}
