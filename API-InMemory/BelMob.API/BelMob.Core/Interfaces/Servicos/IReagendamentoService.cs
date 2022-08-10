using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;

namespace BelMob.Core.Interfaces.Servicos
{
    public interface IReagendamentoService
    {
        public Agendamento Cadastrar(ReagendamentoRequest reagendamento);
        Agendamento BuscarPorId(int Id);
        List<ReagendamentoResponse> Listar();
    }
}
