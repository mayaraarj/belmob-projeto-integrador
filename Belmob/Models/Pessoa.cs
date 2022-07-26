﻿namespace Belmob.Models
{
    public abstract class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }
        public string? Telefone { get; set; }
        public string Celular { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
