using Core.Entities;
using Infra.Data;
using Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Repositories
{
    public class EnderecoRepository : IRepository<Endereco>
    {
        private AppDbContext context;

        public EnderecoRepository(AppDbContext context)
        {
            this.context = context;
        }

        void IRepository<Endereco>.Add(Endereco endereco)
        {
            context.Enderecos.Add(endereco);
            context.SaveChanges();
        }

        void IRepository<Endereco>.Delete(Endereco endereco)
        {
            context.Enderecos.Remove(endereco);
            context.SaveChanges();
        }

        IQueryable<Endereco> IRepository<Endereco>.Get()
        {
            context.Enderecos.AsNoTracking();
            return context.Enderecos;
        }

        Task<Endereco> IRepository<Endereco>.GetById(Expression<Func<Endereco, bool>> predicate)
        {
            return context.Enderecos.SingleOrDefaultAsync(predicate);

        }

        void IRepository<Endereco>.Update(Endereco entity)
        {
            context.Enderecos.Update(entity);           
        }
    }
}
