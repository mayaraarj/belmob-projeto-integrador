﻿namespace Belmob.Models
{
    public class Profissional : Pessoa
    {
        public string Banco { get; set; }
        public char TipoDeConta { get; set; }
        public string ContaComDigito { get; set; }
    }
}
