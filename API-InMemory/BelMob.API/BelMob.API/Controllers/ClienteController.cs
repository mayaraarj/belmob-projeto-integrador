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
    public class ClienteController : ControllerBase
    {
        public IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost("Cadastrar")]
        public ActionResult<ClienteResponse> Cadastrar(CadastroClienteRequest cliente)
        {
            return Ok(_clienteService.Cadastrar(cliente));
        }

        [HttpGet("Listar")]
        public ActionResult<List<ClienteResponse>> GetAll()
        {
            return Ok(_clienteService.Listar());
        }

        [HttpGet("BuscarPeloId")]
        public ActionResult<ClienteResponse> BuscarPelaId(int Id)
        {
            return Ok(_clienteService.BuscarPorId(Id));
        }
        [HttpPut("AlterarDados")]
        public ActionResult<ClienteResponse> Alterar(int Id, int IdEndereco, CadastroClienteRequest cliente)
        {
            return Ok(_clienteService.AlterarDados(Id, IdEndereco, cliente));

        }
        [HttpDelete("Deletar")]
        public ActionResult<ClienteResponse> Deletar(int Id)
        {
            return Ok(_clienteService.Deletar(Id));
        }

    }
}

