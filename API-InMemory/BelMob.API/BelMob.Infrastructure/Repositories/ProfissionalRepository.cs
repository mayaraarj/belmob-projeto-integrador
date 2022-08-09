using BelMob.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.Interfaces;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Entidades;
using BelMob.Core.DTOs.Request;

namespace BelMob.Infrastructure.Repositories
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly SistemaContext _context;

        public ProfissionalRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public void Criar(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            //return profissional;
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Profissionais.FirstOrDefault(p => p.Id == id);
        }

        public List<Usuario> Listar()
        {
            return _context.Profissionais.ToList();
        }
        public Usuario AlterarDados(int id)
        {
            var result = _context.Profissionais.Find(id);
            _context.SaveChanges();
            return result;
        }
        public Usuario Deletar(int id)
        {
            var profissional = _context.Profissionais.FirstOrDefault(p => p.Id == id);
            _context.Remove(profissional);
            _context.SaveChanges();
            return profissional;
        }
    }
}
