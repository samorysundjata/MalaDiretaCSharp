using Core.Entities;

namespace Infra.Repositories.Interfaces
{
    public interface IDestinatarioRepository : IRepository<Destinatario>
    {
        void Delete(Task<Destinatario> Destinatario);

        Endereco Get(int id);

        Task<IEnumerable<Destinatario>> GetDestinatarios();
    }
}
