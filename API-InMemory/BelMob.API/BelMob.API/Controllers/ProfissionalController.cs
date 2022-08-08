using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        public IProfissionalService _profissionalService;
        //public IAgendamentoService _agendamentoService;

        public ProfissionalController(IProfissionalService profissionalService/*, IAgendamentoService agendamentoService*/)
        {
            _profissionalService = profissionalService;
            //_agendamentoService = agendamentoService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroProfissionalRequest profissional)
        {
            _profissionalService.Cadastrar(profissional);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ProfissionalResponse>> GetAll()
        {
            return Ok(_profissionalService.Listar());
        }

        [HttpGet("{Id}")]
        public ActionResult<ProfissionalResponse> BuscarPelaId(int Id)
        {
            return Ok(_profissionalService.BuscarPorId(Id));
        }

        //[HttpGet("AgendamentosDisponiveis")]
        //public ActionResult<AgendamentoResponse> Disponiveis()
        //{
        //    return Ok(_agendamentoService.ListarDisponiveis());
        //}

        [HttpPut("{Id}")]
        public ActionResult<Profissional> Alterar(int Id, CadastroProfissionalRequest profissional)
        {
            return Ok(_profissionalService.AlterarDados(Id, profissional));
        }

        [HttpDelete("{Id}")]
        public ActionResult<Profissional> Deletar(int Id)
        {

            return Ok(_profissionalService.Deletar(Id));
        }
        //[HttpPut("{IdProfissional}/agendamentos/{IdAgendamento}")]
        //public ActionResult<AgendamentoResponse> AceitarAgendamento(int IdProfissional, int IdAgendamento)
        //{
        //    var aceitarAgendamento = new AceitarAgendamentoRequest(IdAgendamento, IdProfissional);
        //    return Ok(_agendamentoService.AceitarAgendamento(aceitarAgendamento));

        //}
    }
}

