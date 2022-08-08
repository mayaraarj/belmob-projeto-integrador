using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Request
{
    public class CadastroClienteRequest
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Rua { get;  set; }

        public TipoEndereco Tipo { get; set; }

        public string Cep { get;  set; }

        public string Numero { get;  set; }

        public string Complemento { get;  set; }
    }
}


