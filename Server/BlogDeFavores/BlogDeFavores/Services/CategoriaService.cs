using System.Collections.Generic;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class CategoriaService: ICategoriaService
    {
        private readonly ICategoriaDao _categoriaDao;

        public CategoriaService(ICategoriaDao categoriaDao)
        {
            this._categoriaDao = categoriaDao;
        }

        public Categoria Registrar(Categoria categoria)
        {
            if (_categoriaDao.ValidateCategoria(categoria))
            {
                return _categoriaDao.Registrar(categoria);
            }
            return null;
        }

        public List<Categoria> GetAll()
        {
            return _categoriaDao.GetAll();
        }
    }
}
