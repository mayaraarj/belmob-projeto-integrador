using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.DTOs.Response;

namespace BelMob.Core.DTOs.Response
{
    public class AgendamentoResponse 
    {
        public AgendamentoResponse()
        {
        }

        public AgendamentoResponse(DateTime data, TipoServico tipoServico, ClienteResponse clienteResponse)
        {
            Data = data;
            TipoServico = tipoServico;
            ClienteResponse = clienteResponse;
        }

        public AgendamentoResponse(DateTime data, TipoServico tipoServico, ClienteResponse clienteResponse, ProfissionalResponse profissionalResponse) : this(data, tipoServico, clienteResponse)
        {
            ProfissionalResponse = profissionalResponse;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoServico TipoServico { get; set; }
        public ClienteResponse ClienteResponse{ get; set; }
        public ProfissionalResponse ProfissionalResponse{ get; set; }
    }
}
