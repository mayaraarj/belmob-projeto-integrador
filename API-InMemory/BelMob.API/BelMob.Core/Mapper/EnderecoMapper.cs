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
    public static class EnderecoMapper
    {
        public static EnderecoResponse Converter(Endereco endereco)
        {
            var dto = new EnderecoResponse();
            dto.Id = endereco.Id;
            dto.Logradouro = endereco.Logradouro;
            dto.CEP = endereco.CEP;
            dto.Numero = endereco.Numero;
            dto.TipoEndereco = endereco.TipoEndereco;
            dto.Complemento = endereco.Complemento;
            dto.Referencia = endereco.Referencia;
            dto.Bairro = endereco.Bairro;
            dto.Cidade = endereco.Cidade;

            return dto;
        }
    }
}
