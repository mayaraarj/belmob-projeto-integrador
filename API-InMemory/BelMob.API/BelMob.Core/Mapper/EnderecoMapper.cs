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
        public static EnderecoResponse Map(Endereco endereco)
        {
            var dto = new EnderecoResponse();
            dto.Id = endereco.Id;
            dto.Rua = endereco.Rua;
            dto.Cep = endereco.Cep;
            dto.Numero = endereco.Numero;
            dto.Tipo = endereco.Tipo;
            dto.Complemento = endereco.Complemento;

            return dto;
        }
    }
}
