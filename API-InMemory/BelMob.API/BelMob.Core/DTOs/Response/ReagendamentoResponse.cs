using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Response
{
    public class ReagendamentoResponse
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoServico TipoServico { get; set; }
        public ClienteResponse ClienteResponse { get; set; }
        public ProfissionalResponse ProfissionalResponse { get; set; }
    }
}
