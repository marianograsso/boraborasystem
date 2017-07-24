using System.Collections.Generic;
using System.Linq;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Dao
{
    public class CategoriaDao: ICategoriaDao
    {
        private readonly GauchadaDbContext context;

        public CategoriaDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Categoria Registrar(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return categoria;
        }

        public List<Categoria> GetAll()
        {
            return context.Categorias.ToList();
        }

        public bool ValidateCategoria(Categoria categoria)
        {
            var valor = context.Categorias.FirstOrDefault(x => x.Nombre == categoria.Nombre || x.Start == categoria.Start);
            if (valor == null)
            {
                return true;
            }
            return false;
        }
    }
}
