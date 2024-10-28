using Core.Entities;
using Core.Services.Interfaces;
using log4net;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class EnderecoService : IEnderecoService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(DestinatarioService));
        private readonly DbContext _context;

        public EnderecoService(DbContext context)
        {
            context = _context;
        }

        public async Task AddEnderecoAsync(Endereco endereco)
        {
            if (endereco == null)
            {
                throw new ArgumentNullException(nameof(endereco));
            }

            try
            {
                await _context.Set<Endereco>().AddAsync(endereco);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Log.Error("Error adding Endereco", ex);
                throw;
            }
        }

        public async Task DeleteEnderecoAsync(int id)
        {
            try
            {
                var endereco = await _context.Set<Endereco>().FindAsync(id);

                if (endereco == null)
                {
                    throw new KeyNotFoundException($"Endereco with id {id} not found.");
                }

                _context.Set<Endereco>().Remove(endereco);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Log.Error("Error deleting Endereco", ex);
                throw;
            }
        }

        public async Task<IEnumerable<Endereco>> GetAllEnderecosAsync()
        {
            try
            {
                return await _context.Set<Endereco>().ToListAsync();
            }
            catch (Exception ex)
            {
                Log.Error("Error retrieving all Enderecos", ex);
                throw;
            }
        }

        public async Task<Endereco> GetEnderecoByIdAsync(int id)
        {
            try
            {
                var endereco = await _context.Set<Endereco>().FindAsync(id);
                if (endereco == null)
                {
                    throw new KeyNotFoundException($"Endereco with id {id} not found.");
                }

                return endereco;
            }
            catch (Exception ex)
            {
                Log.Error("Error retrieving Endereco by id", ex);
                throw;
            }
        }

        public async Task UpdateEnderecoAsync(Endereco endereco)
        {
            if (endereco == null)
            {
                throw new ArgumentNullException(nameof(endereco));
            }

            try
            {
                _context.Set<Endereco>().Update(endereco);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Log.Error("Error updating Endereco", ex);
                throw;
            }
        }
    }
}
