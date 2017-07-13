using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IComentarioDao
    {
        Comentarios Registrar(Comentarios comentario);
        List<Comentarios> GetAll(Guid id);
        Comentarios GetById(Guid id);
        void Update(Guid id, Comentarios comentario);
    }
}
