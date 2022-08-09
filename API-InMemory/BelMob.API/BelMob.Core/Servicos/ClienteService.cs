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

        public Usuario Cadastrar(CadastroClienteRequest clienteRequest)
        {
            var cliente = clienteRequest.Converter();

            _clienteRepository.Criar(cliente);
            return cliente;
        }

        public Usuario BuscarPorId(int Id)
        {
            return _clienteRepository.BuscarPorId(Id);

        }

        public List<ClienteResponse> Listar()
        {
            var list = _clienteRepository.Listar();

            return list.Select(c => c.Converter()).ToList();
        }

        public Usuario AlterarDados(int Id, int IdEndereco, CadastroClienteRequest clienteRequest)
        {
            var result = _clienteRepository.BuscarPorId(Id);
            result.Sobrenome = clienteRequest.Sobrenome;
            result.Senha = clienteRequest.Senha;
            result.Email = clienteRequest.Email;
            result.Senha = clienteRequest.Senha;
            result.Sexo = clienteRequest.Sexo;
            result.Telefone = clienteRequest.Telefone;
            result.Celular = clienteRequest.Celular;

            var endereco = _clienteRepository.BuscarEndereco(IdEndereco);
            endereco.Logradouro = clienteRequest.Logradouro;
            endereco.CEP = clienteRequest.CEP;
            endereco.Numero = clienteRequest.Numero;
            endereco.Complemento = clienteRequest.Complemento;
            endereco.Referencia = clienteRequest.Referencia;
            endereco.Bairro = clienteRequest.Bairro;
            endereco.Cidade = clienteRequest.Cidade;
            endereco.TipoEndereco = clienteRequest.TipoEndereco;
            return _clienteRepository.AlterarDados(Id);
    }

        public Usuario Deletar(int id)
        {
            return _clienteRepository.Deletar(id);
        }
    }
}
