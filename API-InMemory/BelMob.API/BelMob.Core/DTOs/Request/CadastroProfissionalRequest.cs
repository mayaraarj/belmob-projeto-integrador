using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Request
{
    public class CadastroProfissionalRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
        public TipoDeConta TipoDeConta { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
    }
}
