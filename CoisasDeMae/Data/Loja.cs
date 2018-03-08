using CoisasDeMae.Models;
using Microsoft.EntityFrameworkCore;

namespace CoisasDeMae.Data
{
    public class Loja : DbContext
    {
        public Loja(DbContextOptions<Loja> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Pedido>().ToTable("Pedido");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }


        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}

