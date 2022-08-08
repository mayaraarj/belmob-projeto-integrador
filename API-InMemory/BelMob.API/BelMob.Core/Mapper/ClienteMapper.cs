using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public static class ClienteMapper
    {

        public static ClienteResponse Map(this Cliente cliente)
        {
            var dto = new ClienteResponse();
            dto.Id = cliente.Id;
            dto.Nome = cliente.Nome;
            dto.Enderecos = cliente.Enderecos.Select(c => EnderecoMapper.Map(c)).ToList();


            return dto;

        }


        public static Cliente Map(this CadastroClienteRequest clienteRequest)
        {
            var cliente = new Cliente(clienteRequest.Nome, clienteRequest.Email, clienteRequest.Senha);
            var endereco = new Endereco(clienteRequest.Rua, clienteRequest.Cep, clienteRequest.Numero, clienteRequest.Complemento, Enums.TipoEndereco.Residencial);

            cliente.AdicionarEndereco(endereco);

            return cliente;

        }
    }
}
