using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
   public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Enderecos = new List<Endereco>();

        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public IList<Endereco> Enderecos { get; set; }


        public void AdicionarEndereco(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }

       
    }
}
