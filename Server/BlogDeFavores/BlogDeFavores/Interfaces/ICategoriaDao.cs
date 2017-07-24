using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface ICategoriaDao    
    {
        Categoria Registrar(Categoria categoria);
        List<Categoria> GetAll();
        bool ValidateCategoria(Categoria categoria);
    }
}