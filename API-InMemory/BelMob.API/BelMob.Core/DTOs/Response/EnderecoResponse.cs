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
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
    }
}
