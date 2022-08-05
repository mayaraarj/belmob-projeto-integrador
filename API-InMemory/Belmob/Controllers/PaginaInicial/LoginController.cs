using Belmob.Models;
using Belmob.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belmob.Controllers.PaginaInicial
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]       
        public ActionResult<dynamic> Autenticar(Login login)
        {
            if (login == null)
                return BadRequest(); 
            
            var cliente = DbSistema.Clientes.Where(c => c.Email == login.Email && c.Senha == login.Senha).FirstOrDefault();

            if(cliente == null) { 
                return Unauthorized(); 
            }
            else
            {
                var token = TokenService.GerarChaveToken(cliente);

                cliente.Senha = null;
                return new
                {
                    token = token,
                    cliente = cliente
                };
            }
        }
    }
}
