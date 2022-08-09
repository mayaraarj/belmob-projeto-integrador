using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Interfaces.Servicos;
using BelMob.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Servicos
{
    public class ClienteService : IClienteService
    {
        
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Cadastrar(CadastroClienteRequest clienteRequest)
        {
            var cliente = clienteRequest.Converter();

            _clienteRepository.Criar(cliente);
            return cliente;
        }

        public Cliente BuscarPorId(int Id)
        {
            return _clienteRepository.BuscarPorId(Id);

        }

        public List<ClienteResponse> Listar()
        {
            var list = _clienteRepository.Listar();

            return list.Select(c => c.Converter()).ToList();
        }

        public Cliente AlterarDados(int Id, CadastroClienteRequest clienteRequest)
        {
            var result = _clienteRepository.BuscarPorId(Id);
            result = clienteRequest.Converter();
            return _clienteRepository.AlterarDados(Id);
        }

        public Cliente Deletar(int id)
        {
            return _clienteRepository.Deletar(id);
        }
    }
}
