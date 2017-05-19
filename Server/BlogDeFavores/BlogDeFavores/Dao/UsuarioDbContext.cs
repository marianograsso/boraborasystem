using BlogDeFavores.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogDeFavores.Dao
{
    public class UsuarioDbContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
        }
    }
}