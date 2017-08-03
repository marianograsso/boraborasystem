using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IComprasDao
    {
        Compras Registrar(Compras compra, Usuario user);
        List<Compras> GetByIdUsuario(Guid idUsuario);
    }
}