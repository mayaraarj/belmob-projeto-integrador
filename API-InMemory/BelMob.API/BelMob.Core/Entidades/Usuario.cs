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

        public Usuario(/*TipoUsuario tipoUsuario,*/ string email, string senha, string nome, string? sobrenome, string sexo, string cpf, string? telefone, string celular, DateTime nascimento)
        {
            //TipoUsuario = tipoUsuario;
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
            DataCadastro = DateTime.Now;
        }

        //public Usuario(TipoUsuario tipoUsuario, string email, string senha, string nome, string? sobrenome, string sexo, string cpf, string? telefone, string celular, DateTime nascimento, string? agencia, string? conta, string? banco, TipoConta? tipoConta) : this(tipoUsuario, email, senha, nome, sobrenome, sexo, cpf, telefone, celular, nascimento)
        //{
        //    Enderecos = new List<Endereco>();
        //    Agencia = agencia;
        //    Conta = conta;
        //    Banco = banco;
        //    TipoConta = tipoConta;
        //    DataCadastro = DateTime.Now;
        //}

        [Key]
        public int Id { get; set; }
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
        public List<Endereco> Enderecos { get; set; }
        ////public string? Agencia { get; set; }
        ////public string? Conta { get; set; }
        ////public string? Banco { get; set; }
        ////public TipoConta? TipoConta { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
