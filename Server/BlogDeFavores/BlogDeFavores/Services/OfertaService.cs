using BlogDeFavores.Controllers;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class OfertaService: IOfertaService
    {
        private readonly IOfertaDao ofertaDao;

        public OfertaService(IOfertaDao ofertaDao)
        {
            this.ofertaDao = ofertaDao;
        }

        public Oferta Registrar(Oferta oferta)
        {
            return ofertaDao.Registrar(oferta);
        }
    }
}