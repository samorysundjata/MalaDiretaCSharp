namespace Core.Entities
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public Endereco(string logradouro, string numero, string cidade, string estado, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }

        public bool ValidarEndereco()
        {
            // Implement validation logic here
            return true;
        }

        public bool ValidarCEP()
        {
            // Implement CEP validation logic here
            return true;
        }

        public void Exibir()
        {
            // Implement display logic here
            Console.WriteLine($"{Logradouro}, {Numero}, {Cidade}, {Estado}, {CEP}");
        }
    }
}
