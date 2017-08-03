using System;
using System.Collections.Generic;
using System.Linq;
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

        public CompraDto GetComprasByUsuario(Guid idUsuario)
        {
            var usuario = usuarioDao.GetById(idUsuario);
            var compraDto = new CompraDto
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido
            };
            var comprasDeUsuario = comprasDao.GetByIdUsuario(idUsuario);
            foreach (var c in comprasDeUsuario)
            {
                compraDto.TotalCreditos = compraDto.TotalCreditos + c.CantCreditos;
                compraDto.TotalPrecio = compraDto.TotalPrecio + c.Precio;
            }
            return compraDto;
        }

        public List<CompraDto> GetCompras()
        {
            var usuarios = usuarioDao.GetAll();
            return usuarios.Select(u => GetComprasByUsuario(u.Id)).ToList();
        }
    }
}