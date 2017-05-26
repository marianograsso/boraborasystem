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
            context.Compras.Add(compra);
            user.Credito = user.Credito + compra.CantCreditos;
            context.Usuarios.Update(user);
            context.SaveChanges();
            return compra;
        }
    }
}