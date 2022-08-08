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

        public Cliente AlterarDados(CadastroClienteRequest clienteRequest, int id)
        {
            var result = _context.Clientes.Find(id);
            result.Nome = clienteRequest.Nome;
            result.Email = clienteRequest.Email;
            result.Senha = clienteRequest.Senha;
            var endereco = _context.Enderecos.Find(id);
            endereco.Rua = clienteRequest.Rua;
            endereco.Numero = clienteRequest.Numero;
            endereco.Cep = clienteRequest.Cep;
            endereco.Complemento = clienteRequest.Complemento;
            endereco.Tipo = clienteRequest.Tipo;
            _context.Clientes.Include(c => c.Enderecos);
            _context.SaveChanges();
            return result;
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.Include(c => c.Enderecos).FirstOrDefault(c => c.Id == id);
        }

        public bool Criar(Cliente cliente)
        {
            _context.Add(cliente);
            return _context.SaveChanges() > 0;
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

