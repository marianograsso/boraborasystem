using System;
using System.Linq;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IUsuarioDao
    {
        Usuario GetById(Guid id);
        Usuario Registrar(Usuario usuario);
        void Eliminar(Guid id);
        void Editar(Guid id, Usuario usuario);
        Usuario GetByEmailyPassword(string email, string password);
    }
}