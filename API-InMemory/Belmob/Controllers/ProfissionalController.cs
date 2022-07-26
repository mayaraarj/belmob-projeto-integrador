using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Belmob.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Belmob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();

        [HttpPost]
        public ActionResult<Profissional> PublicarUm(Profissional profissional)
        {
            if (profissional == null)
                return BadRequest();

            if (DbSistema.Profissionais.Any(c => c.CPF == profissional.CPF))
                return Conflict();

            DbSistema.Profissionais.Add(profissional);
            DbSistema.SaveChanges();
            return Ok(profissional);
        }

        [HttpGet]
        public ActionResult<ProfissionalController> RequererTodosAtendimentos()
        {
            return Ok(DbSistema.Profissionais.ToList());
            //return NoContent();
        }

        [HttpGet("{Id}")]
        public ActionResult<ProfissionalController> RequererProfissionalPelaId(int Id)
        {
            var resultado = DbSistema.Profissionais.Find(Id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        //// GET: api/<ProfissionalController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ProfissionalController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProfissionalController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProfissionalController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProfissionalController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
