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

        public Endereco(string rua, string cep, string numero, string complemento, TipoEndereco tipo)
        {
            Rua = rua;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Tipo = tipo;
        }

        [Key]
        public int Id { get; set; }

        public string Rua { get;  set; }

        public string Cep { get;  set; }

        public string Numero { get;  set; }

        public string Complemento { get;  set; }

        public TipoEndereco Tipo { get;  set; }

    }
}
