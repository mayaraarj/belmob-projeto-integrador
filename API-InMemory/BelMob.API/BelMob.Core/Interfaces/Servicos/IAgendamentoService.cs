using BelMob.Core.DTOs.Request;
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
        AgendamentoResponse Cadastrar(CadastroAgendamentoRequest agendamentoRequest, int IdCliente);
        AgendamentoResponse BuscarPorId(int Id);
        List<AgendamentoResponse> Listar();
        List<AgendamentoResponse> ListarDisponiveis();
        AgendamentoResponse AceitarAgendamento(int id, int IdProfissional);
        AgendamentoResponse AlterarDados(int Id, CadastroAgendamentoRequest agendamentoRequest);
        AgendamentoResponse Deletar(int id);
        AgendamentoResponse Reagendar(CadastroAgendamentoRequest reagendamento, int id);
    }
}
