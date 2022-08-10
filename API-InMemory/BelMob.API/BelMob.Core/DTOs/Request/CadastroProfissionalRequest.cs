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
        //public TipoUsuario TipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string? Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Banco { get; set; }
        public TipoConta TipoConta { get; set; }
    }
}
