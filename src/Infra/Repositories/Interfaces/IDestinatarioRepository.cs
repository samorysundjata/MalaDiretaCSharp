using Core.Entities;

namespace Infra.Repositories.Interfaces
{
    public interface IDestinatarioRepository : IRepository<Destinatario>
    {
        Endereco Get(int id);

        Task<IEnumerable<Destinatario>> GetDestinatarios();
    }
}
