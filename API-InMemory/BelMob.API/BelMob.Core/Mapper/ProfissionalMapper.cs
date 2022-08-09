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
    public static class ProfissionalMapper
    {
        public static Usuario Converter(this CadastroProfissionalRequest request)
        {
            var dto = new Usuario(request.TipoUsuario, request.Nome, request.Email, request.Senha, request.Sobrenome, request.Sexo, request.CPF, request.Telefone, request.Celular, request.Nascimento, request.Banco, request.Agencia, request.Conta, request.TipoConta);

            return dto;
        }

        public static ProfissionalResponse Converter(Usuario profissional)
        {
            var response = new ProfissionalResponse();
            response.Id = profissional.Id;
            response.Nome = profissional.Nome;     
           
            return response;
        }
    }
}
