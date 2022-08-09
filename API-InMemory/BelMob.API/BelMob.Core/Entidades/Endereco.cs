using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Endereco
    {
        public Endereco() { }

        public Endereco(string cep, string logradouro, string numero, string? complemento, string? referencia, string bairro, string cidade, TipoEndereco tipoEndereco)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Referencia = referencia;
            Bairro = bairro;
            Cidade = cidade;
            TipoEndereco = tipoEndereco;
        }

        [Key]
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
