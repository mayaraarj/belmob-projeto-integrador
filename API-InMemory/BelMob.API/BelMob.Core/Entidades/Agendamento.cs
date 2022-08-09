using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoServico TipoServico { get; set; }        
        public TipoPagamento TipoPagamento { get; set; }
        public string AdicionarCupom { get; set; }
        public Usuario Cliente { get; set; }
        public Usuario? Profissional { get; set; }
        public TipoServico TipoDeServico { get; internal set; }
    }
}
