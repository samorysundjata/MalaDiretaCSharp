using Core.Entities;
using Infra.Data;
using Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Repositories
{
    public class DestinatarioRepository : IRepository<Destinatario>
    {
        private AppDbContext context;

        public DestinatarioRepository(AppDbContext context)
        {
            this.context = context;
        }

        void IRepository<Destinatario>.Add(Destinatario destinatario)
        {
            context.Destinatarios.Add(destinatario);
            context.SaveChanges();
        }

        void IRepository<Destinatario>.Delete(Destinatario destinatario)
        {
            context.Destinatarios.Remove(destinatario);
            context.SaveChanges();
        }

        IQueryable<Destinatario> IRepository<Destinatario>.Get()
        {
            context.Destinatarios.AsNoTracking();
            return context.Destinatarios;
        }

        Task<Destinatario> IRepository<Destinatario>.GetById(Expression<Func<Destinatario, bool>> predicate)
        {
            return context.Destinatarios.SingleOrDefaultAsync(predicate);

        }

        void IRepository<Destinatario>.Update(Destinatario entity)
        {
            context.Destinatarios.Update(entity);
        }

        public Endereco Get(int id)
        {
            return context.Enderecos.Find(id);
        }
    }
}
