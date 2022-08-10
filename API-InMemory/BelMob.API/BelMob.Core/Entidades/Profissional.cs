using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Profissional : Usuario
    {
        public Profissional()
        {

        }
        public Profissional(string? agencia, string? conta, string? banco, TipoConta? tipoConta, DateTime dataCadastro)
        {
            Agencia = agencia;
            Conta = conta;
            Banco = banco;
            TipoConta = tipoConta;
            DataCadastro = dataCadastro;
        }

        public Profissional(string nome, string email, string senha, string? sobrenome, string sexo, string cPF, string? telefone, string celular, DateTime nascimento, string banco, string agencia, string conta, TipoConta tipoConta)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Sobrenome = sobrenome;
            Sexo = sexo;
            CPF = cPF;
            Telefone = telefone;
            Celular = celular;
            Nascimento = nascimento;
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            TipoConta = tipoConta;
        }

        public string? Agencia { get; set; }
        public string? Conta { get; set; }
        public string? Banco { get; set; }
        public TipoConta? TipoConta { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
