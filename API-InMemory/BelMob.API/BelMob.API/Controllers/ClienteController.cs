﻿using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroClienteRequest cliente)
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
        public ActionResult<Cliente> Alterar(int Id, CadastroClienteRequest cliente)
        {
            return Ok(_clienteService.AlterarDados(Id, cliente));

        }
        [HttpDelete("{Id}")]
        public ActionResult<Cliente> Deletar(int Id)
        {

            return Ok(_clienteService.Deletar(Id));
        }
    }
}
