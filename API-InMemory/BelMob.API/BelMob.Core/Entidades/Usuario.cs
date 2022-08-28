using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public abstract class Usuario
    {
        public Usuario() { }

        public Usuario(string email, string senha, string nome, string? sobrenome, string sexo, string cpf, string? telefone, string celular, DateTime nascimento)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            Sobrenome = sobrenome;
            Sexo = sexo;
            CPF = cpf;
            Telefone = telefone;
            Celular = celular;
            Nascimento = nascimento;
            Enderecos = new List<Endereco>();
        }

        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string? Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}
