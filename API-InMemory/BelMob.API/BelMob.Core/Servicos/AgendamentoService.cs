using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Interfaces.Servicos;
using BelMob.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Servicos
{
    public class AgendamentoService : IAgendamentoService
    {
        private IAgendamentoRepository _agendamentoRepository;
        private IClienteRepository _clienteRepository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository, IClienteRepository clienteRepository)
        {
            _agendamentoRepository = agendamentoRepository;
            _clienteRepository = clienteRepository;
        }

        public AgendamentoResponse BuscarPorId(int Id)
        {
            var result = _agendamentoRepository.BuscarPorId(Id);
            return AgendamentoMapper.Converter(result);

        }

        public AgendamentoResponse Cadastrar(CadastroAgendamentoRequest agendamentoRequest)
        {
            var cliente = _clienteRepository.BuscarPorId(agendamentoRequest.IdCliente);
            var agendamento = agendamentoRequest.Converter();
            agendamento.AdicionarCliente(cliente);
            var result = _agendamentoRepository.Criar(agendamento);

            return AgendamentoMapper.Converter(result);
        }
        public List<AgendamentoResponse> Listar()
        {
            var list = _agendamentoRepository.Listar();
            return list.Select(c => AgendamentoMapper.Converter(c)).ToList();
        }

        public List<AgendamentoResponse> ListarDisponiveis()
        {
            var list = _agendamentoRepository.ListarDisponiveis();

            return list.Select(c => AgendamentoMapper.Converter(c)).ToList();
        }
        public AgendamentoResponse AlterarDados(int Id, CadastroAgendamentoRequest agendamentoRequest)
        {
            var agendamento = _agendamentoRepository.BuscarPorId(Id);
            agendamento.Data = agendamentoRequest.Data;
            agendamento.TipoServico = agendamentoRequest.TipoServico;
            agendamento.TipoPagamento = agendamentoRequest.TipoPagamento;
            agendamento.AdicionarCupom = agendamentoRequest.AdicionarCupom;
            var result = _agendamentoRepository.AlterarDados(Id);
            return AgendamentoMapper.Converter(result);
        }
        public AgendamentoResponse AceitarAgendamento(AceitarAgendamentoRequest aceitar)
        {
            return _agendamentoRepository.AceitarAgendamento(aceitar).Converter();
        }
        public AgendamentoResponse Deletar(int id)
        {
            var agendamento = _agendamentoRepository.Deletar(id);
            return AgendamentoMapper.Converter(agendamento);
        }
        public AgendamentoResponse Reagendar(CadastroAgendamentoRequest reagendamento, int id)
        {
            var agendamentoAnterior = _agendamentoRepository.BuscarPorId(id);
            var agendamento = reagendamento.Converter();
            agendamento.AdicionarCliente(agendamentoAnterior.Cliente);
            agendamento.AdicionarProfissional(agendamentoAnterior.Profissional);
            var result = _agendamentoRepository.Criar(agendamento);
            return AgendamentoMapper.Converter(result);
        }
        public List<AgendamentoResponse> ListarProximos(int IdProfissional)
        {
            var list = _agendamentoRepository.ListarProximos(IdProfissional);
            return list.Select(c => AgendamentoMapper.Converter(c)).ToList();
        }
        public List<AgendamentoResponse> ListarPassados(int IdProfissional)
        {
            var list = _agendamentoRepository.ListarProximos(IdProfissional);
            return list.Select(c => AgendamentoMapper.Converter(c)).ToList();
        }

        public List<AgendamentoResponse> ListarHistoricoCliente(int idCliente)
        {
            var list = _agendamentoRepository.ListarHistoricoCliente(idCliente);
            return list.Select(c => AgendamentoMapper.Converter(c)).ToList();
        }
    }
}
