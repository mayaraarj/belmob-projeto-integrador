using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public class AgendamentoMapper
    {
        public static AgendamentoResponse Map(this Agendamento agendamento)
        {
            var dto = new AgendamentoResponse();
            dto.Id = agendamento.Id;
            dto.Data = agendamento.Data;
            dto.TipoServico = agendamento.TipoServico;

            if (agendamento.Usuarios != null)
                dto.ClienteResponse = ClienteMapper.Converter (agendamento.Usuarios);

            return dto;
        }
        public static Agendamento Map(this CadastroAgendamentoRequest agendamentoRequest)
        {



            return new Agendamento(agendamentoRequest.Data, agendamentoRequest.TipoDeServico);
        }
    }
}
