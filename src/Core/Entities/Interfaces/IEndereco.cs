namespace Core.Entities.Interfaces
{
    public interface IEndereco
    {
        string Logradouro { get; }
        string Numero { get; }
        string Cidade { get; }
        string Estado { get; }
        string CEP { get; }
    }
}
