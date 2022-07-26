﻿using Microsoft.EntityFrameworkCore;

namespace Belmob.Models
{
    public class SistemaContext : DbContext
    {
        public DbSet<Atendimento>? Atendimentos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Endereco>? enderecos { get; set; }
        public DbSet<Profissional>? profissionals { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<Atendimento>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
            });
            Modelagem.Entity<Cliente>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
            });
            Modelagem.Entity<Endereco>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
            });
            Modelagem.Entity<Profissional>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder Configurar)
        {

            Configurar.UseInMemoryDatabase("Belmob-InMemory");
        }
    }
}
