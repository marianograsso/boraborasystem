using System;
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

        public Categoria Editar(Guid id, Categoria categoria)
        {
            Categoria cate = GetById(id);
            cate.Nombre = categoria.Nombre;
            cate.Start = categoria.Start;
            cate.Imagen = categoria.Imagen;
            context.Categorias.Update(cate);
            context.SaveChanges();
            return cate;
        }

        public Categoria GetById(Guid id)
        {
            return context.Categorias.Find(id);
        }

        public void Borrar(Guid id)
        {
            context.Categorias.Remove(GetById(id));
            context.SaveChanges();
        }

        public Categoria GetByStart(int start)
        {
            var list = context.Categorias.Where(x => x.Start <= start);
            return list.SingleOrDefault(y => y.Start == list.Max(r => r.Start));
        }

        public CategoriaDto GetCategoriaByPuntaje(Guid puntaje)
        {
            throw new NotImplementedException();
        }
    }
}
