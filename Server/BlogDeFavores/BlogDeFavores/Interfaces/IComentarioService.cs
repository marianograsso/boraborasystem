using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IComentarioService
    {
        Comentarios Registrar(Comentarios comentario);
        List<Comentarios> GetAll(Guid id);
        void Update(Guid id, Comentarios comentario);
    }
}