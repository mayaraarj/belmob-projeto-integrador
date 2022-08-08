using BelMob.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace BelMob.Core.Entidades
{
    public class Profissional
    {
        public Profissional()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
        public TipoDeConta TipoDeConta { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
    }
}
