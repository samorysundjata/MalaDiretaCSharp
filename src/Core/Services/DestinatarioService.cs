using Core.Entities;
using Core.Services.Interfaces;
using log4net;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class DestinatarioService: IDestinatarioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(DestinatarioService));
        private readonly DbContext _context;

        public DestinatarioService(DbContext context)
        {
            context = _context;
        }
       
        public async Task<IEnumerable<Destinatario>> GetAllDestinatariosAsync()
        {
            try
            {
                return await _context.Set<Destinatario>().ToListAsync();
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred while retrieving all destinatarios: {ex.Message}", ex);
                throw new Exception($"An error occurred while retrieving all destinatarios: {ex.Message}", ex);
            }
        }

        public async Task<Destinatario?> GetDestinatarioByIdAsync(int id)
        {
            try
            {
                return await _context.Set<Destinatario>().FindAsync(id);
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred while retrieving the destinatario with ID {id}: {ex.Message}", ex);
                throw new Exception($"An error occurred while retrieving the destinatario with ID {id}: {ex.Message}", ex);
            }
        }

        public async Task AddDestinatarioAsync(Destinatario destinatario)
        {
            if (destinatario == null)
            {
                throw new ArgumentNullException(nameof(destinatario));
            }
            else
            {
                try
                {
                    await _context.Set<Destinatario>().AddAsync(destinatario);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Log.Error($"An error occurred while adding the destinatario: {ex.Message}", ex);
                    throw new Exception($"An error occurred while adding the destinatario: {ex.Message}", ex);
                }
            }
        }

        public async Task UpdateDestinatarioAsync(Destinatario destinatario)
        {
            if (destinatario == null)
            {
                throw new ArgumentNullException(nameof(destinatario));
            }

            try
            {
                _context.Set<Destinatario>().Update(destinatario);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred while updating the destinatario with ID {destinatario.Id}: {ex.Message}", ex);
                throw new Exception($"An error occurred while updating the destinatario with ID {destinatario.Id}: {ex.Message}", ex);
            }
        }

        public async Task DeleteDestinatarioAsync(int id)
        {
            var destinatario = await _context.Set<Destinatario>().FindAsync(id);
            if (destinatario != null)
            {
                try
                {
                    _context.Set<Destinatario>().Remove(destinatario);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Log.Error($"An error occurred while deleting the destinatario with ID {id}: {ex.Message}", ex);
                    throw new Exception($"An error occurred while deleting the destinatario with ID {id}: {ex.Message}", ex);
                }
            }
        }
        
        public async Task<Endereco> GetEnderecoByDestinatarioIdAsync(int destinatarioId)
        {
            try
            {
                var destinatario = await _context.Set<Destinatario>().Include(d => d.Endereco).FirstOrDefaultAsync(d => d.Id == destinatarioId);
                return destinatario.Endereco;
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred while retrieving the endereco for destinatario with ID {destinatarioId}: {ex.Message}", ex);
                throw new Exception($"An error occurred while retrieving the endereco for destinatario with ID {destinatarioId}: {ex.Message}", ex);
            }
        }
        
    }
}
