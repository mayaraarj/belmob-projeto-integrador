using BelMob.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Infrastructure.Contexts
{
    public class SistemaContext : DbContext
    {
        public SistemaContext(DbContextOptions<SistemaContext> options) : base(options)
        {

        }

        public DbSet<Cliente>? Clientes { get; set; }

        public DbSet<Endereco>? Enderecos { get; set; }

    }
}
