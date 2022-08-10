using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Cliente : Usuario
    {
        public Cliente()
        {
        }
        public Cliente(string email, string senha, string nome, string? sobrenome, string sexo, string cpf, string? telefone, string celular, DateTime nascimento) : base(email, senha, nome, sobrenome, sexo, cpf, telefone, celular, nascimento)
        {
        }
    }
}
