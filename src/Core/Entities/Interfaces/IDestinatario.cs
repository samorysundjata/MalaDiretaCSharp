namespace Core.Entities.Interfaces
{
    public interface IDestinatario
    {
        IEndereco Endereco { get; }
        bool ValidarEndereco();
    }
}
