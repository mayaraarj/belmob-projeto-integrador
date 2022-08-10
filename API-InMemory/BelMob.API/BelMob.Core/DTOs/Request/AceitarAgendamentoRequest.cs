using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Request
{
    public class AceitarAgendamentoRequest
    {
        public AceitarAgendamentoRequest(int idAgendamento, int idProfissional)
        {
            IdAgendamento = idAgendamento;
            IdProfissional = idProfissional;
        }

        public int IdProfissional { get; set; }
        public int IdAgendamento { get; set; }
    }
}
