﻿namespace Belmob.Models
{
    public class Profissional : Pessoa
    {
        public List<Atendimento>? Atendimentos { get; set; }
        public string Banco { get; set; }
        public string TipoDeConta { get; set; }
        public string Agencia { get; set; }
        public string ContaComDigito { get; set; }

    }
}
