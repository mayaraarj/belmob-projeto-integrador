using Belmob.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        [Authorize(Roles = "Cliente")]
        public ActionResult<Endereco> CadastrarEndereco(Endereco endereco)
        {
            if (endereco == null)
                return BadRequest();

            DbSistema.Enderecos.Add(endereco);
            DbSistema.SaveChanges();
            return Ok(endereco);
        }

        [HttpGet]
        [Authorize(Roles = "Administrador")]
        public ActionResult<Endereco> RequererTodosEnderecos()
        {
            return Ok(DbSistema.Enderecos.ToList());
        }

        [HttpGet("{Id}")]
        [Authorize(Roles = "Administrador")]
        public ActionResult<Endereco> RequererEnderecoPelaId(int Id)
        {
            var resultado = DbSistema.Enderecos.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }


        [HttpDelete("{Id}")]
        [Authorize(Roles = "Administrador, Cliente")]
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
        [Authorize(Roles = "Cliente")]
        public ActionResult<Endereco> SubstituirDadosDoEnderecoPelaId(int Id, Endereco endereco)
        {
            if (endereco == null)
                return BadRequest();

            if (endereco.Id != Id)
                return BadRequest();

            var resultado = DbSistema.Enderecos.Find(Id);

            if (resultado == null)
                return NotFound();

            resultado.Logradouro = endereco.Logradouro;
            resultado.TipoDeEndereco = endereco.TipoDeEndereco;
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
