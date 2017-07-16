using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Oferta> GetByGauchadaId(Guid id)
        {
            return context.Ofertas.Where(x => x.GauchadaId == id).ToList();
        }

        public Oferta GetById(Guid id)
        {
            return context.Ofertas.Find(id);
        }

        public bool ValidateOffer(Guid usuarioId, Guid gauchadaId)
        {
            var valor = context.Ofertas.FirstOrDefault(x => x.IdOfertador == usuarioId && x.GauchadaId == gauchadaId);
            // si no me trajo nada, es porque no existe esa oferta
            if (valor == null)
            {
                return true;
            }
            return false;
        }

        public void Editar(Guid id, Oferta oferta)
        {
            var offer = GetById(id);
            offer.Estado = oferta.Estado;
            offer.IdCalificacion = oferta.IdCalificacion;
            context.Ofertas.Update(offer);
            context.SaveChanges();
        }

        public void RechazarTodas(Guid idGauchada)
        {
            var list = context.Ofertas.Where(x => x.GauchadaId == idGauchada).ToList();
            list.ForEach(a => a.Estado = 0);
            context.SaveChanges();
        }

        public List<Oferta> GetByOfertadorId(Guid id)
        {
            return context.Ofertas.Where(x => x.IdOfertador == id).ToList();
        }
    }
}