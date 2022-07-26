namespace Belmob.Models
{
    public class Atendimento
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Profissional Profissional { get; set; }
        public Endereco Endereco { get; set; }
    }
}
