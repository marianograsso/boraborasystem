using System;
using System.Collections.Generic;
using System.Linq;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Dao
{
    public class ComprasDao: IComprasDao
    {
        private readonly GauchadaDbContext context;

        public ComprasDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Compras Registrar(Compras compra, Usuario user)
        {
            //compra.Usuario = user;
            context.Compras.Add(compra);
            context.SaveChanges();
            user.Credito = user.Credito + compra.CantCreditos;
            context.Usuarios.Update(user);
            context.SaveChanges();
            return compra;
        }

        public List<Compras> GetByIdUsuario(Guid idUsuario)
        {
            //esto nos trae todas las compras de un uusario
            //
            return context.Compras.Where(x => x.IdComprador == idUsuario && x.Fecha.Month == DateTime.Today.Month).ToList();
        }
    }
}