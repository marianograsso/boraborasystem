using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IComprasService
    {
        Compras Registrar(Compras compra);
        CompraDto GetComprasByUsuario(Guid idUsuario);
        List<CompraDto> GetCompras();
    }
}