using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class CompraService: IComprasService
    {
        private readonly IComprasDao comprasDao;
        private readonly IUsuarioDao usuarioDao;

        public CompraService(IComprasDao comprasDao, IUsuarioDao usuarioDao)
        {
            this.comprasDao = comprasDao;
            this.usuarioDao = usuarioDao;
        }

        public Compras Registrar(Compras compra)
        {
            var usuario = usuarioDao.GetById(compra.IdComprador);
            return comprasDao.Registrar(compra, usuario);
        }
    }
}