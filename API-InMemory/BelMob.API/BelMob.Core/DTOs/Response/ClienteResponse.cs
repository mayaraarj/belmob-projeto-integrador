using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.DTOs.Response
{
    public  class ClienteResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<EnderecoResponse> Enderecos { get; set; }
    }
}
