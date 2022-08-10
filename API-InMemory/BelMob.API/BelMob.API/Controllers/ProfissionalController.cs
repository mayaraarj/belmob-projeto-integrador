using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        public IProfissionalService _profissionalService;
        public IAgendamentoService _agendamentoService;

        public ProfissionalController(IProfissionalService profissionalService, IAgendamentoService agendamentoService)
        {
            _profissionalService = profissionalService;
            _agendamentoService = agendamentoService;
        }

        [HttpPost("Cadastrar")]
        public ActionResult<ProfissionalResponse> CadastrarProfissional(CadastroProfissionalRequest profissional)
        {
            return Ok(_profissionalService.Cadastrar(profissional));
        }
      
        [HttpGet("Listar")]
        public ActionResult<List<ProfissionalResponse>> GetAll()                                                                                                                                                                                                        
        {
            return Ok(_profissionalService.Listar());
        }
       
        [HttpGet("BuscarPeloId")]
        public ActionResult<ProfissionalResponse> BuscarPelaId(int Id)
        {
            return Ok(_profissionalService.BuscarPorId(Id));
        }

        [HttpGet("AgendamentosDisponiveis")]
        public ActionResult<AgendamentoResponse> Disponiveis()
        {
            return Ok(_agendamentoService.ListarDisponiveis());
        }

        [HttpPut("AlterarDados")]
        public ActionResult<ProfissionalResponse> Alterar(int Id, CadastroProfissionalRequest profissional)
        {
            return Ok(_profissionalService.AlterarDados(Id, profissional));
        }

        [HttpDelete("Deletar")]
        public ActionResult<ProfissionalResponse> Deletar(int Id)
        {

            return Ok(_profissionalService.Deletar(Id));
        }
        [HttpPut("AceitarAgendamento")]
        public ActionResult<AgendamentoResponse> AceitarAgendamento(int IdProfissional, int IdAgendamento)
        {
           
            return Ok(_agendamentoService.AceitarAgendamento(IdAgendamento, IdProfissional));
        }
        
    }
}

