namespace Core.Entities
{
    public class Destinatario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Destinatario(Endereco endereco)
        {
            Endereco = endereco;
        }

        public bool ValidarEndereco()
        {
            return !string.IsNullOrEmpty(Endereco.Logradouro) &&
                   !string.IsNullOrEmpty(Endereco.Numero) &&
                   !string.IsNullOrEmpty(Endereco.Cidade) &&
                   !string.IsNullOrEmpty(Endereco.Estado) &&
                   !string.IsNullOrEmpty(Endereco.CEP);
        }

        public bool ValidarCEP()
        {
            return Endereco.CEP.Length == 8 && int.TryParse(Endereco.CEP, out _);
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Endereço: {Endereco.Logradouro}, {Endereco.Numero}, {Endereco.Cidade}, {Endereco.Estado}, {Endereco.CEP}");
        }
    }
}
