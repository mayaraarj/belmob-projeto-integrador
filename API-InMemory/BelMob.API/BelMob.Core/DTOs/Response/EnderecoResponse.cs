using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Response
{
    public  class EnderecoResponse
    {
        public int Id { get; set; }

        public string Rua { get;  set; }

        public string Cep { get;  set; }

        public string Numero { get;  set; }

        public string Complemento { get;  set; }

        public TipoEndereco Tipo { get;  set; }
    }
}
