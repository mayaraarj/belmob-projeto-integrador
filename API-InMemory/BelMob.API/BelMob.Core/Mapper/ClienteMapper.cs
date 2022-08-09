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
        public static ClienteResponse Converter(this Usuario cliente)
        {
            var dto = new ClienteResponse();
            dto.Id = cliente.Id;
            dto.Nome = cliente.Nome;
            dto.Enderecos = cliente.Enderecos.Select(c => EnderecoMapper.Converter(c)).ToList();
            return dto;
        }
        public static Usuario Converter(this CadastroClienteRequest request)
        {
            var dto = new Usuario(request.TipoUsuario, request.Nome, request.Email, request.Senha, request.Sobrenome, request.Sexo, request.CPF, request.Telefone, request.Celular, request.Nascimento);

            dto.Enderecos = new List<Endereco>();
            dto.Enderecos.Add(new Endereco(request.Logradouro, request.CEP, request.Numero, request.Complemento, request.Referencia, request.Bairro, request.Cidade, Enums.TipoEndereco.Residencial));
            dto.DataCadastro = DateTime.Now;

            return dto;
        }
    }
}
