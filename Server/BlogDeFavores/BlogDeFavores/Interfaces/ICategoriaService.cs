using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface ICategoriaService
    {
        Categoria Registrar(Categoria categoria);
        List<Categoria> GetAll();
        void Eliminar(Guid id);
        Categoria Editar(Guid id, Categoria categoria);
        Categoria GetCategoriaByStart(int start);
        List<CategoriaDto> GetRanking();
    }
}