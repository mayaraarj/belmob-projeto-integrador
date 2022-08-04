using Belmob.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Belmob.Controllers.PaginaDoCliente
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<Models.Cliente> CadastrarCliente(Models.Cliente cliente)
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
        [Authorize(Roles = "Administrador")]
        public ActionResult<Models.Cliente> RequererTodosClientes()
        {
            return Ok(DbSistema.Clientes.ToList());
        }

  
        [HttpGet("{Id}")]
        [Authorize(Roles = "Administrador,Cliente")]
        public ActionResult<Models.Cliente> RequererClientePelaId(int Id)
        {
            var resultado = DbSistema.Clientes.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpDelete("{Id}")]
        [Authorize(Roles = "Administrador, Cliente")]
        public ActionResult<Models.Cliente> DeletarClientePelaId(int Id)
        {
            var resultado = DbSistema.Clientes.Find(Id);

            if (resultado == null)
                return NotFound();

            DbSistema.Clientes.Remove(resultado);
            DbSistema.SaveChanges();
            return Ok(resultado);
        }

        [HttpPut("{Id}")]
        [Authorize(Roles = "Administrador")]
        public ActionResult<Models.Cliente> SubstituirDadosDeUmClientePelaId(int Id, Models.Cliente cliente)
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
