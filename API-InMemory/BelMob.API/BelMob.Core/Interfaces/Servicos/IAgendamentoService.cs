using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Servicos
{
    public interface IAgendamentoService
    {
        Agendamento Cadastrar(CadastroAgendamentoRequest agendamento);
        public Agendamento BuscarPorId(int Id);

        List<AgendamentoResponse> Listar();
        List<AgendamentoResponse> ListarDisponiveis();

        //Agendamento AceitarAgendamento(AceitarAgendamentoRequest aceitarAgendamento);
    }
}
