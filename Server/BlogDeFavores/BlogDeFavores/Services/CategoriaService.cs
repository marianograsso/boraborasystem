using System;
using System.Collections.Generic;
using System.Linq;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class CategoriaService: ICategoriaService
    {
        private readonly ICategoriaDao _categoriaDao;
        private readonly IUsuarioDao usuarioDao;

        public CategoriaService(ICategoriaDao categoriaDao, IUsuarioDao usuarioDao)
        {
            this._categoriaDao = categoriaDao;
            this.usuarioDao = usuarioDao;
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

        public void Eliminar(Guid id)
        {
            _categoriaDao.Borrar(id);
        }

        public Categoria Editar(Guid id, Categoria categoria)
        {
            if (_categoriaDao.ValidateCategoria(categoria))
            {
                return _categoriaDao.Editar(id, categoria);
            }
            return null;
        }

        public Categoria GetCategoriaByStart(int start)
        {
            return _categoriaDao.GetByStart(start);
        }

        public CategoriaDto GetCategoriaByPuntaje(Guid idUsuario)
        {
            var usuario = usuarioDao.GetById(idUsuario);
            var categoriaDto = new CategoriaDto
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Puntaje = usuario.Puntaje
            };
            var categoria = _categoriaDao.GetByStart(usuario.Puntaje);
            categoriaDto.NombreCat = categoria.Nombre;
            return categoriaDto;
        }

        public List<CategoriaDto> GetRanking()
        {
            var usuarios = usuarioDao.GetAll();
            return usuarios.Select(u => GetCategoriaByPuntaje(u.Id)).ToList();
        }
    }
}
