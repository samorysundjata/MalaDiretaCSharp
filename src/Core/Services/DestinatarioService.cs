using Core.Entities;
using Core.Services.Interfaces;
using log4net;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class DestinatarioService : IDestinatarioService
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(DestinatarioService));
        private readonly DbContext _context;

        public DestinatarioService(DbContext context)
        {
            _context = context;
        }

        public async Task AddDestinatarioAsync(Destinatario destinatario)
        {
            if (destinatario == null)
            {
                throw new ArgumentNullException(nameof(destinatario));

            } else
            { 
                try
                {
                    await _context.Set<Destinatario>().AddAsync(destinatario);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Log.Error($"An error occurred while adding the destinatario: {ex.Message}", ex);
                    throw; // Re-throw the exception to ensure the caller is aware of the failure
                }
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
                    Log.Error($"An error occurred while deleting the destinatario: {ex.Message}", ex);
                    throw; // Re-throw the exception to ensure the caller is aware of the failure
                }
            }
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
                throw; // Re-throw the exception to ensure the caller is aware of the failure
            }
        }

        public async Task<Destinatario> GetDestinatarioByIdAsync(int id)
        {
            try
            {
                return await _context.Set<Destinatario>().FindAsync(id);
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred while retrieving the destinatario with ID {id}: {ex.Message}", ex);
                throw; // Re-throw the exception to ensure the caller is aware of the failure
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
                throw; // Re-throw the exception to ensure the caller is aware of the failure
            }
        }
    }
}
