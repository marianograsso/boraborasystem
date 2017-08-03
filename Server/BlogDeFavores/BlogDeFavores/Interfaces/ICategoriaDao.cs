using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface ICategoriaDao    
    {
        Categoria Registrar(Categoria categoria);
        List<Categoria> GetAll();
        bool ValidateCategoria(Categoria categoria);
        Categoria Editar(Guid id, Categoria categoria);
        void Borrar(Guid id);
        Categoria GetByStart(int start);
        CategoriaDto GetCategoriaByPuntaje(Guid puntaje);
    }
}