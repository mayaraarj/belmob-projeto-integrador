using static Belmob.Models.Enums;

namespace Belmob.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TipoDeServico TipoDeServico { get; set; }
        public TipoDePagamento TipoDePagamento { get; set; }
        public string CupomDesconto { get; set; }
        public Cliente? Cliente { get; set; }
        public Endereco? Endereco { get; set; }
        public Profissional? Profissional { get; set; }
    }
}
