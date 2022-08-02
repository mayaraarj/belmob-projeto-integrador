namespace Belmob.Models
{
    public class Cliente : Pessoa
    {
        public List<Atendimento>? Atendimentos { get; set; }
        public string Role = "Cliente";
    }
}
