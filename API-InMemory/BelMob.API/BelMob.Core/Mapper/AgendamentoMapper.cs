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
    public static class AgendamentoMapper
    {
        public static AgendamentoResponse Converter(this Agendamento agendamento)
        {
            var dto = new AgendamentoResponse();
            dto.Id = agendamento.Id;
            dto.Data = agendamento.Data;
            dto.TipoServico = agendamento.TipoServico;
            dto.ClienteResponse = ClienteMapper.Converter(agendamento.Cliente);
            if (agendamento.Profissional != null)
            {
                dto.ProfissionalResponse = ProfissionalMapper.Converter(agendamento.Profissional);
            }
            return dto;
        }
        public static Agendamento Converter(this CadastroAgendamentoRequest agendamentoRequest)
        {
            return new Agendamento(agendamentoRequest.Data, agendamentoRequest.TipoServico, agendamentoRequest.TipoPagamento, agendamentoRequest.AdicionarCupom);
        }
    }
}
