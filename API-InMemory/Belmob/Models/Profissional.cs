namespace Belmob.Models
{
    public class Profissional : Pessoa
    {
        public string Banco { get; set; }
        public string TipoDeConta { get; set; }
        public string Agencia { get; set; }
        public string ContaComDigito { get; set; }

        public string Role = "Profissional";
    }
}
