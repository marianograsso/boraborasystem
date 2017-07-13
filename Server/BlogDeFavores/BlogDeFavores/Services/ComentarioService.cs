using System;
using System.Collections.Generic;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class ComentarioService: IComentarioService
    {
        private readonly IComentarioDao _comentarioDao;

        public ComentarioService(IComentarioDao comentarioDao)
        {
            _comentarioDao = comentarioDao;
        }

        public Comentarios Registrar(Comentarios comentario)
        {
            return _comentarioDao.Registrar(comentario);
        }

        public List<Comentarios> GetAll(Guid id)
        {
            return _comentarioDao.GetAll(id);
        }

        public void Update(Guid id, Comentarios comentario)
        {
            _comentarioDao.Update(id, comentario);
        }
    }
}