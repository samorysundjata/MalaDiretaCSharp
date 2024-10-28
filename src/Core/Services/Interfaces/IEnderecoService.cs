using Core.Entities;

namespace Core.Services.Interfaces
{
    public interface IEnderecoService
    {
        Task<Endereco> GetEnderecoByIdAsync(int id);
        Task<IEnumerable<Endereco>> GetAllEnderecosAsync();
        Task AddEnderecoAsync(Endereco endereco);
        Task UpdateEnderecoAsync(Endereco endereco);
        Task DeleteEnderecoAsync(int id);
    }
}
