using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public interface ICalifacionDao
    {
        Calificacion Registrar(Calificacion calificacion);
    }
}