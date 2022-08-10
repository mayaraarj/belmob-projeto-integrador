using BelMob.Core.DTOs.Request;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IAgendamentoRepository
    {
        Agendamento Criar(Agendamento agendamento);
        Agendamento BuscarPorId(int id);
        List<Agendamento> Listar();
        List<Agendamento> ListarDisponiveis();
        Agendamento AceitarAgendamento(AceitarAgendamentoRequest aceitarAgendamento);
        Agendamento AlterarDados(int id);
        Agendamento Deletar(int id);
    }
}
