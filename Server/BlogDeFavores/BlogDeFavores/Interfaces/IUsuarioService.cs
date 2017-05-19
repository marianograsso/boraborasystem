using System;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IUsuarioService
    {
        Usuario GetById(Guid id);
        Usuario Registrar(Usuario usuario);
        void Eliminar(Guid id);
        void Editar(Guid id, Usuario usuario);
    }
}