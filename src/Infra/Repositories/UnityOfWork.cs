using Infra.Data;
using Infra.Repositories.Interfaces;

namespace Infra.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private DestinatarioRepository _destinatarioRepository;

        private EnderecoRepository _enderecoRepository;

        public AppDbContext _context { get; set; }

        public UnityOfWork(AppDbContext context) => _context = context;

        public IDestinatarioRepository DestinatarioRepository
        {
            get
            {
                return (IDestinatarioRepository)(_destinatarioRepository = _destinatarioRepository ?? new DestinatarioRepository(_context));
            }
        }

        public IEnderecoRepository EnderecoRepository
        {
            get
            {
                return (IEnderecoRepository)(_enderecoRepository = _enderecoRepository ?? new EnderecoRepository(_context));
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose() => _context.Dispose();
    }
}
