using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Request
{
    public class ReagendamentoRequest
    {
        public DateTime Data { get; set; }
        public TipoServico TipoServico { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public string AdicionarCupom { get; set; }
        public int IdAgendamentoAnterior { get; set; }
    }
}
