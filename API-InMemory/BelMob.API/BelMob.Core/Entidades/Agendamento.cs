using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Agendamento
    {
        public Agendamento() { }

        public Agendamento(DateTime data, TipoServico tipoServico, TipoPagamento tipoPagamento, string adicionarCupom, string endereco)
        {
            Data = data;
            TipoServico = tipoServico;
            TipoPagamento = tipoPagamento;
            AdicionarCupom = adicionarCupom;
            Endereco = endereco;
            Cliente = new Cliente();
        }

        public Agendamento(DateTime data, TipoServico tipoServico, TipoPagamento tipoPagamento, string adicionarCupom, Cliente cliente, Profissional profissional)
        {
            Cliente = new Cliente();
            Profissional = new Profissional();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoServico TipoServico { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public string? AdicionarCupom { get; set; }
        public Cliente Cliente { get; set; }
        public Profissional? Profissional { get; set; }
        public string Endereco { get; set; }
        public void AdicionarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public void AdicionarProfissional(Profissional profissional)
        {
            Profissional = profissional;
        }
    }
}
