using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;
using Microsoft.EntityFrameworkCore;

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
        [HttpDelete("{Id}")]
        public ActionResult<Cliente> DeletarClientePelaId(int Id)
        {
            var resultado = DbSistema.Clientes.Find(Id);

            if (resultado == null)
                return NotFound();

            DbSistema.Clientes.Remove(resultado);
            DbSistema.SaveChanges();
            return Ok(resultado);
        }

        [HttpPut("{Id}")]
        public ActionResult<Cliente> SubstituirUmPelaId(int Id, Cliente cliente)
        {
            if (cliente == null)
                return BadRequest();

            if (cliente.Id != Id)
                return BadRequest();

            var resultado = DbSistema.Clientes.Find(Id);

            if (resultado == null)
                return NotFound();

            if (DbSistema.Clientes.Any(u => u.Id != Id && u.CPF == cliente.CPF))
                return Conflict();

            resultado.Nome = cliente.Nome;
            resultado.Email = cliente.Email;
            resultado.Sexo = cliente.Sexo;
            resultado.Telefone = cliente.Telefone;
            resultado.Celular = cliente.Celular;
            resultado.CPF = cliente.CPF;
            resultado.DataNascimento = cliente.DataNascimento;
            DbSistema.SaveChanges();
            return Ok(cliente);
        }
    }
}


