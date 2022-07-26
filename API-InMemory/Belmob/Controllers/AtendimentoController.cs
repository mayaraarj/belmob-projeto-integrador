using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Atendimento> PublicarUm(Atendimento atendimento)
        {
            if (atendimento == null)
                return BadRequest();            

            DbSistema.Atendimentos.Add(atendimento);
            DbSistema.SaveChanges();
            return Ok(atendimento);
        }

        [HttpGet]
        public ActionResult<AtendimentoController> RequererTodosAtendimentos()
        {
            return Ok(DbSistema.Atendimentos.ToList());
        }

        [HttpGet("{Id}")]
        public ActionResult<AtendimentoController> RequererAtendimentosPelaId(int Id)
        {
            var resultado = DbSistema.Atendimentos.FirstOrDefault(u => u.Id == Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        //// GET: api/<AtendimentoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<AtendimentoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<AtendimentoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<AtendimentoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<AtendimentoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
