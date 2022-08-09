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

        [HttpPost]
        public ActionResult<Usuario> Cadastrar(CadastroClienteRequest cliente)
        {
            _clienteService.Cadastrar(cliente);
            return Ok(cliente);
        }

        [HttpGet]
        public ActionResult<List<ClienteResponse>> GetAll()
        {
            return Ok(_clienteService.Listar());
        }

        [HttpGet("{Id}")]
        public ActionResult<ClienteResponse> BuscarPelaId(int Id)
        {
            return Ok(_clienteService.BuscarPorId(Id));
        }
        [HttpPut("{Id}")]
        public ActionResult<Usuario> Alterar(int Id, int IdEndereco, CadastroClienteRequest cliente)
        {
            return Ok(_clienteService.AlterarDados(Id, IdEndereco, cliente));

        }
        [HttpDelete("{Id}")]
        public ActionResult<Usuario> Deletar(int Id)
        {

            return Ok(_clienteService.Deletar(Id));
        }
    }
}

