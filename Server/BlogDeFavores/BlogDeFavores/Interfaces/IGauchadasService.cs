using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IGauchadasService
    {
        void GetById(Guid id);
        List<Gauchada> GetByAutor(Guid id);
        List<Gauchada> GetByActor(Guid id);
        Gauchada Registrar(Gauchada gauchada);
        void Eliminar(Guid id);
        void Editar(Guid id, Gauchada gauchada);
    }
}