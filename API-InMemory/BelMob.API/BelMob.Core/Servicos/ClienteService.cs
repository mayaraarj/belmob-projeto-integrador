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

        Cliente IClienteService.AlterarDados(int Id, CadastroClienteRequest cliente)
        {
            return _clienteRepository.AlterarDados(cliente, Id);
        }

        Cliente IClienteService.BuscarPorId(int Id)
        {
           return _clienteRepository.BuscarPorId(Id);
        }

        bool IClienteService.Cadastrar(CadastroClienteRequest clienteRequest)
        {
            var user = ClienteMapper.Converter(clienteRequest);

            return _clienteRepository.Criar(user);
        }

        Cliente IClienteService.Deletar(int id)
        {
            return _clienteRepository.Deletar(id);
        }

        List<ClienteResponse> IClienteService.Listar()
        {
            var list = _clienteRepository.Listar();

            return list.Select(c => ClienteMapper.Converter(c)).ToList();
        }
    }
}
