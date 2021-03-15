using Core.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexto
{
    public class ContextoBancoDeDados : DbContext
    {
        public ContextoBancoDeDados(DbContextOptions<ContextoBancoDeDados> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>()
                .HasIndex(p => p.ClienteId)
                .IsUnique(true);
        }
    }
}
