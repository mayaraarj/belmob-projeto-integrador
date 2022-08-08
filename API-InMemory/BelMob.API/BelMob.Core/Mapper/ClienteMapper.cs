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
        public static Cliente Converter(CadastroClienteRequest request)
        {
            var dto = new Cliente();
            dto.Nome = request.Nome;
            dto.Email = request.Email;
            dto.Senha = request.Senha;
            
            var endereco = new Endereco(request.Rua, request.Cep,request.Numero,request.Complemento, Enums.TipoEndereco.Residencial);

            dto.AdicionarEndereco(endereco);

            return dto;

        }
        public static ClienteResponse Converter(Cliente cliente)
        {
            var dto = new ClienteResponse();
            dto.Id = cliente.Id;
            dto.Nome = cliente.Nome;
            dto.Enderecos = cliente.Enderecos.Select(c => EnderecoMapper.Map(c)).ToList();


            return dto;

        }
    }
}
