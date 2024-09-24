using Core.Entities;

namespace Infra.Repositories.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Endereco Get(int id);

        Task<IEnumerable<Endereco>> GetEnderecos();
    }
}
