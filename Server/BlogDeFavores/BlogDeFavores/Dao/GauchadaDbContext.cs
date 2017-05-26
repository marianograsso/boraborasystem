using BlogDeFavores.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogDeFavores.Dao
{
    public class GauchadaDbContext: DbContext
    {
        public DbSet<Gauchada> Gauchadas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Compras> Compras { get; set; }

        public GauchadaDbContext(DbContextOptions<GauchadaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gauchada>().ToTable("Gauchada");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Compras>().ToTable("Compras");
        }

    }
}