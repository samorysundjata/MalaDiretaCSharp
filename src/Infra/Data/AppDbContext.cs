using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infra.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Destinatario> Destinatarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration) => _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
    }
}
