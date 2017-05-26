using System;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IComprasDao
    {
        Compras Registrar(Compras compra, Usuario user);
    }
}