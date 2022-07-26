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


        //    // GET: api/<EnderecoController>
        //    [HttpGet]
        //    public IEnumerable<string> Get()
        //    {
        //        return new string[] { "value1", "value2" };
        //    }

        //    // GET api/<EnderecoController>/5
        //    [HttpGet("{id}")]
        //    public string Get(int id)
        //    {
        //        return "value";
        //    }

        //    // POST api/<EnderecoController>
        //    [HttpPost]
        //    public void Post([FromBody] string value)
        //    {
        //    }

        //    // PUT api/<EnderecoController>/5
        //    [HttpPut("{id}")]
        //    public void Put(int id, [FromBody] string value)
        //    {
        //    }

        //    // DELETE api/<EnderecoController>/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
    }
}
