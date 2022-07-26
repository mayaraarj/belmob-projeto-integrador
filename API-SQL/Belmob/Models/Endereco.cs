namespace Belmob.Models
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string Referencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
