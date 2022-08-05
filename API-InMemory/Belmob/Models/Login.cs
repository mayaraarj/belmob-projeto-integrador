using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;
using Microsoft.AspNetCore.Authorization;

namespace Belmob.Models
{
    [Route("api/[models]")]
    [ApiController]
    public class Login : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        public string Email { get; set; }

        public string Senha { get; set; }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<Login> RealizarLogin(Login login)
        {
            if (login == null)
                return BadRequest();

            //if (DbSistema.Login.Any(c => c.Email == login.Email))
            //    return Conflict();

            //DbSistema.Login.Add(login);
           DbSistema.SaveChanges();
           return Ok(login);
        }
    }
}