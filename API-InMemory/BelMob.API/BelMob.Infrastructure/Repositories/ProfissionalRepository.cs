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

        public Profissional Criar(Profissional profissional)
        {
            _context.Add(profissional);
            _context.SaveChanges();
            return profissional;
        }
 
        public Profissional BuscarPorId(int id)
        {
            var profissional = _context.Profissionais.FirstOrDefault(c => c.Id == id);
            _context.SaveChanges();
            return profissional;
        }

        public List<Profissional> Listar()
        {
            return _context.Profissionais.ToList();
        }
        public Profissional AlterarDados(int id)
        {
            var result = _context.Profissionais.Find(id);
            _context.SaveChanges();
            return result;
        }
        public Profissional Deletar(int id)
        {
            var profissional = _context.Profissionais.FirstOrDefault(p => p.Id == id);
            _context.Remove(profissional);
            _context.SaveChanges();
            return profissional;
        }
    }
}
