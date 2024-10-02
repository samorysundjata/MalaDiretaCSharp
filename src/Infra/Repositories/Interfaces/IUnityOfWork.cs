namespace Infra.Repositories.Interfaces
{
    public interface IUnityOfWork
    {
        IDestinatarioRepository DestinatarioRepository { get; }

        IEnderecoRepository EnderecoRepository { get; }

        Task Commit();
    }
}
