using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Cliente> PublicarUm(Cliente cliente)
        {
            if (cliente == null)
                return BadRequest();

            if (DbSistema.Clientes.Any(c => c.CPF == cliente.CPF))
                return Conflict();

            DbSistema.Clientes.Add(cliente);
            DbSistema.SaveChanges();
            return Ok(cliente);
        }

        [HttpGet]
        public ActionResult<Cliente> RequererTodosClientes()
        {
            return Ok(DbSistema.Clientes.ToList());
        }

        [HttpGet("{Id}")]
        public ActionResult<Cliente> RequererClientePelaId(int Id)
        {
            var resultado = DbSistema.Clientes.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }   
    }
}
