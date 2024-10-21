using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Core.Entities
{
    [Table("Enderecos")]
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }

        //public Endereco() { }

        //public Endereco(string logradouro, string numero, string cidade, string estado, string cep)
        //{
        //    Logradouro = logradouro;
        //    Numero = numero;
        //    Cidade = cidade;
        //    Estado = estado;
        //    CEP = cep;
        //}

        //public bool ValidarEndereco(Endereco endereco)
        //{
        //    if (string.IsNullOrWhiteSpace(Logradouro) || string.IsNullOrWhiteSpace(Numero) ||
        //        string.IsNullOrWhiteSpace(Cidade) || string.IsNullOrWhiteSpace(Estado) ||
        //        string.IsNullOrWhiteSpace(CEP))
        //    {
        //        return false;
        //    }

        //    if (!ValidarCEP(endereco.CEP))
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //public bool ValidarCEP(string cep)
        //{
        //    var regex = new Regex(@"^\d{5}-\d{3}$");
        //    return regex.IsMatch(cep);
        //}

        //public void Exibir()
        //{
        //    Console.WriteLine($"{Logradouro}, {Numero}, {Cidade}, {Estado}, {CEP}");
        //}
    }
}
