using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Endereco> PublicarUm(Endereco endereco)
        {
            if (endereco == null)
                return BadRequest();

            DbSistema.Enderecos.Add(endereco);
            DbSistema.SaveChanges();
            return Ok(endereco);
        }

        [HttpGet]
        public ActionResult<Endereco> RequererTodosEnderecos()
        {
            return Ok(DbSistema.Enderecos.ToList());
        }

        [HttpGet("{Id}")]
        public ActionResult<Endereco> RequererEnderecosPelaId(int Id)
        {
            var resultado = DbSistema.Enderecos.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpDelete("{Id}")]
        public ActionResult<Endereco> DeletarEnderecoPelaId(int Id)
        {
            var resultado = DbSistema.Enderecos.Find(Id);

            if (resultado == null)
                return NotFound();

            DbSistema.Enderecos.Remove(resultado);
            DbSistema.SaveChanges();
            return Ok(resultado);
        }

        [HttpPut("{Id}")]
        public ActionResult<Endereco> SubstituirUmPelaId(int Id, Endereco endereco)
        {
            if (endereco == null)
                return BadRequest();

            if (endereco.Id != Id)
                return BadRequest();

            var resultado = DbSistema.Enderecos.Find(Id);

            if (resultado == null)
                return NotFound();

            if (DbSistema.Enderecos.Any(u => u.Id != Id))
                return Conflict();

            resultado.Logradouro = endereco.Logradouro;
            resultado.Numero = endereco.Numero;
            resultado.Complemento = endereco.Complemento;
            resultado.Referencia = endereco.Referencia;
            resultado.Bairro = endereco.Bairro;
            resultado.Cidade = endereco.Cidade;
            resultado.Estado = endereco.Estado;
            DbSistema.SaveChanges();
            return Ok(endereco);
        }
    }
}
