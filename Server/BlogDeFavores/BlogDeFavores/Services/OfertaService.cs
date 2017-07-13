using System;
using System.Collections.Generic;
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

        public List<Oferta> GetByGauchadaId(Guid id)
        {
            return ofertaDao.GetByGauchadaId(id);
        }

        public bool ValidateOffer(Guid usuarioId, Guid gauchadaId)
        {
            return ofertaDao.ValidateOffer(usuarioId, gauchadaId);
        }

        public void Editar(Guid id, Oferta oferta)
        {
            ofertaDao.Editar(id, oferta);
        }

        public void RechazarTodas(Guid idGauchada)
        {
            ofertaDao.RechazarTodas(idGauchada);
        }
    }
}