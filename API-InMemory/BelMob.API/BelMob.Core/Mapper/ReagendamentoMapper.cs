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
    public static class ReagendamentoMapper
    {
        public static ReagendamentoResponse Converter(this Agendamento reagendamento)
        {
            var dto = new ReagendamentoResponse();
            dto.Id = reagendamento.Id;
            dto.Data = reagendamento.Data;
            dto.TipoServico = reagendamento.TipoServico;

            if (reagendamento.Cliente != null)
                dto.ClienteResponse = ClienteMapper.Converter(reagendamento.Cliente);

            if (reagendamento.Profissional != null)
                dto.ProfissionalResponse = ProfissionalMapper.Converter(reagendamento.Profissional);

            return dto;
        }

        public static Agendamento Converter(this ReagendamentoRequest reagendamentoRequest)
        {
            return new Agendamento(reagendamentoRequest.Data, reagendamentoRequest.TipoServico, reagendamentoRequest.TipoPagamento, reagendamentoRequest.AdicionarCupom);
        }
    }
}
