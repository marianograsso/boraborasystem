using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using BlogDeFavores.Services;

namespace BlogDeFavores.Dao
{
    public class OfertaDao: IOfertaDao
    {
        private readonly GauchadaDbContext context;

        public OfertaDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Oferta Registrar(Oferta oferta)
        {
            context.Ofertas.Add(oferta);
            context.SaveChanges();
            return oferta;
        }
    }
}