using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface ICategoriaService
    {
        Categoria Registrar(Categoria categoria);
        List<Categoria> GetAll();
    }
}