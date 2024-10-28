using Core.Entities;

namespace Core.Services.Interfaces
{
    public interface IDestinatarioService
    {
        Task<Destinatario> GetDestinatarioByIdAsync(int id);
        Task<IEnumerable<Destinatario>> GetAllDestinatariosAsync();
        //Task<Endereco> GetEnderecoByDestinatarioIdAsync(int destinatarioId);
        Task AddDestinatarioAsync(Destinatario destinatario);
        Task UpdateDestinatarioAsync(Destinatario destinatario);
        Task DeleteDestinatarioAsync(int id);
    }
}
