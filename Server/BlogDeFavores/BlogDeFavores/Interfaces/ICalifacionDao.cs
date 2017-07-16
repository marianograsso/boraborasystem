using System;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface ICalifacionDao
    {
        Calificacion Registrar(Calificacion calificacion);
        Calificacion GetById(Guid id);
    }
}