using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IUsuarioService
    {
        Usuario GetById(Guid id);
        Usuario Registrar(Usuario usuario);
        void Eliminar(Guid id);
        void Editar(Guid id, Usuario usuario);
        Usuario GetByEmailyPassword(string email, string password);
        bool ValidateEmail(string email);
        List<object> GetRankings();
        List<object> GetCompras();
    }
}