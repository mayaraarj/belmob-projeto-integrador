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
    public class ProfissionalMapper
    {
        public static Profissional Converter(CadastroProfissionalRequest request)
        {
            var dto = new Profissional();
            dto.Nome = request.Nome;
            dto.Email = request.Email;
            dto.Senha = request.Senha;
            dto.Banco = request.Banco;
            dto.TipoDeConta = request.TipoDeConta;
            dto.Conta = request.Conta;
            dto.Agencia = request.Agencia;

            return dto;
        }

        public static ProfissionalResponse Converter(Profissional profissional)
        {
            var response = new ProfissionalResponse();
            response.Id = profissional.Id;
            response.Nome = profissional.Nome;     
           
            return response;
        }
    }
}
