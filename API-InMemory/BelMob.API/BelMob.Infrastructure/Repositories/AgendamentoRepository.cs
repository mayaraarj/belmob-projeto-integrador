using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.DTOs.Request;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BelMob.Infrastructure.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly SistemaContext _context;

        public AgendamentoRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public Agendamento Criar(Agendamento agendamento)
        {
            _context.Add(agendamento);
            _context.SaveChanges();
            return agendamento;
        }

        public Agendamento BuscarPorId(int id)
        {
            return _context.Agendamentos.Include(a => a.Cliente).Include(a => a.Cliente.Enderecos).Include(a => a.Profissional).FirstOrDefault(a => a.Id == id);
        }

        public List<Agendamento> Listar()
        {
            return _context.Agendamentos.Include(i => i.Cliente).Include(i => i.Cliente.Enderecos).Include(a => a.Profissional).ToList();
        }

        public List<Agendamento> ListarDisponiveis()
        {
            return _context.Agendamentos.Include(i => i.Cliente).Include(i => i.Cliente.Enderecos).Include(i => i.Profissional).Where(a => a.Profissional == null).ToList();
        }

        public Agendamento AceitarAgendamento(AceitarAgendamentoRequest aceitar)
        {
            var agendamento = _context.Agendamentos.Include(a => a.Cliente).Include(a => a.Cliente.Enderecos).Include(a => a.Profissional).FirstOrDefault(a => a.Id == aceitar.IdAgendamento);
            var profissional = _context.Profissionais.FirstOrDefault(p => p.Id == aceitar.IdProfissional);
            agendamento.AdicionarProfissional(profissional);
            _context.Agendamentos.Include(a => a.Cliente).Include(a => a.Cliente.Enderecos).Include(a => a.Profissional);
            _context.SaveChanges();
            return agendamento;
        }
        public Agendamento AlterarDados(int id)
        {
            var result = _context.Agendamentos.Include(c => c.Cliente).Include(e => e.Cliente.Enderecos).Include(c => c.Profissional).FirstOrDefault(c => c.Id == id);
            _context.SaveChanges();
            return result;
        }
        public Agendamento Deletar(int id)
        {
            var agendamento = _context.Agendamentos.Include(c => c.Cliente).Include(c => c.Cliente.Enderecos).Include(c => c.Profissional).FirstOrDefault(c => c.Id == id);
            _context.Remove(agendamento);
            _context.SaveChanges();
            return agendamento;
        }

    }
}
