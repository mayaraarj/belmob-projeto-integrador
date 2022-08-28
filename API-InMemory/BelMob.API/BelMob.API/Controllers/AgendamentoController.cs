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
    public class AgendamentoController : ControllerBase
    {
        public IAgendamentoService _agendamentoService;
        public IClienteService _clienteService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [HttpPost("Agendar")]
        public ActionResult<AgendamentoResponse> Criar(CadastroAgendamentoRequest agendamento)
        {
            return Ok(_agendamentoService.Cadastrar(agendamento));
        }
        [HttpPost("Reagendar")]
        public ActionResult<AgendamentoResponse> Reagendar(CadastroAgendamentoRequest reagendamento, int id)
        {
            return Ok(_agendamentoService.Cadastrar(reagendamento));

        }

        [HttpGet("Listar")]
        public ActionResult<List<AgendamentoResponse>> GetAll()
        {
            return Ok(_agendamentoService.Listar());
        }

        [HttpGet("BuscarPeloId")]
        public ActionResult<AgendamentoResponse> BuscarPelaId(int Id)
        {
            return Ok(_agendamentoService.BuscarPorId(Id));
        }
        [HttpPut("AlterarDados")]
        public ActionResult<AgendamentoResponse> AlterarDados(int Id, CadastroAgendamentoRequest agendamentoRequest)
        {
            return Ok(_agendamentoService.AlterarDados(Id, agendamentoRequest));
        }
        [HttpDelete("Deletar")]
        public ActionResult<Agendamento> Deletar(int Id)
        {
            return Ok(_agendamentoService.Deletar(Id));
        }

        [HttpGet("ListarHistoricoCliente")]
        public ActionResult<List<AgendamentoResponse>> ListarHistoricoCliente(int id)
        {
            return Ok(_agendamentoService.ListarHistoricoCliente(id));
        }
    }
}


