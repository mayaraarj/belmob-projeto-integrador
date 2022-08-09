using BelMob.Core.DTOs.Request;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.Enums;

namespace BelMob.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SistemaContext _context;

        public ClienteRepository(SistemaContext ctx)
        {
            _context = ctx;
        }
        public Cliente AlterarDados(int id)
        {
            var result = _context.Clientes.Include(c => c.Enderecos).FirstOrDefault(c => c.Id == id);
            _context.SaveChanges();
            return result;
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.Include(c => c.Enderecos).FirstOrDefault(c => c.Id == id);
        }

        public Cliente Criar(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }
        public Endereco BuscarEndereco(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);
            return endereco;
        }
        public List<Cliente> Listar()
        {
            return _context.Clientes.Include(c => c.Enderecos).ToList();
        }

        public Cliente Deletar(int id)
        {
            var cliente = _context.Clientes.Include(c => c.Enderecos).FirstOrDefault(c => c.Id == id);
            _context.Remove(cliente);
            _context.SaveChanges();
            return cliente;

        }

    }    
}

