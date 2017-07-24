using BlogDeFavores.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogDeFavores.Dao
{
    public class GauchadaDbContext: DbContext
    {
        public DbSet<Gauchada> Gauchadas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public GauchadaDbContext(DbContextOptions<GauchadaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gauchada>().ToTable("Gauchada");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Compras>().ToTable("Compras");
            modelBuilder.Entity<Oferta>().ToTable("Oferta");
            modelBuilder.Entity<Comentarios>().ToTable("Comentarios");
            modelBuilder.Entity<Calificacion>().ToTable("Calificaciones");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
        }

    }
}