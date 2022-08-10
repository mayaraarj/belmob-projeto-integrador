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

        public ClienteResponse Cadastrar(CadastroClienteRequest clienteRequest)
        {
            var clientes = _clienteRepository.Listar();
            foreach (var verificar in clientes)
            {
                if (verificar.CPF == clienteRequest.CPF)
                {
                    throw new Exception("CPF já existe no banco de dados");
                }
                if (verificar.Email == clienteRequest.Email)
                {
                    throw new Exception("Email já existe no banco de dados");
                }
            }
            var cliente = clienteRequest.Converter();
            return _clienteRepository.Criar(cliente).Converter();
        }

        public ClienteResponse BuscarPorId(int Id)
        {
            var cliente = _clienteRepository.BuscarPorId(Id).Converter();
            return cliente;
        }

        public List<ClienteResponse> Listar()
        {
            var list = _clienteRepository.Listar();

            return list.Select(c => c.Converter()).ToList();
        }

        public ClienteResponse AlterarDados(int Id, int IdEndereco, CadastroClienteRequest clienteRequest)
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

            return _clienteRepository.AlterarDados(Id).Converter();
        }

        public ClienteResponse Deletar(int id)
        {
            var result = _clienteRepository.Deletar(id);
            return ClienteMapper.Converter(result);
        }
    }
}
