using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;
using Microsoft.AspNetCore.Authorization;

namespace Belmob.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Login : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        public string Email { get; set; }

        public string Senha { get; set; }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<Login> CadastrarProfissional(Login login)
        {
            if (login == null)
                return BadRequest();

            if (DbSistema.Profissionais.Any(c => c.Email == login.Email))
                return Conflict();

            DbSistema.Login.Add(login);
            DbSistema.SaveChanges();
            return Ok(login);
        }
    }
}