using System;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface ICalificacionService
    {
        Calificacion Registrar(Calificacion calificacion);
        Calificacion GetById(Guid id);
    }
}