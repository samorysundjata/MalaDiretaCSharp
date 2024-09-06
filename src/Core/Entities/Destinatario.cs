namespace Core.Entities
{
    public class Destinatario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}
