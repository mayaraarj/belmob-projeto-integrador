using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;
using Microsoft.AspNetCore.Authorization;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<Contato> PublicarNovoContato(Contato contato)
        {
            if (contato == null)
                return BadRequest();

            DbSistema.Contatos.Add(contato);
            DbSistema.SaveChanges();
            return Ok(contato);
        }
        [HttpGet]
        [Authorize(Roles = "Administrador, Profissional")]
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
