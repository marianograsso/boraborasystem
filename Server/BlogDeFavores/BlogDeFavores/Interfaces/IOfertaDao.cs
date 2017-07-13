using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IOfertaDao   
    {
        Oferta Registrar(Oferta oferta);
        List<Oferta> GetByGauchadaId(Guid id);
        bool ValidateOffer(Guid usuarioId, Guid gauchadaId);
        void Editar(Guid id, Oferta oferta);
        Oferta GetById(Guid id);
        void RechazarTodas(Guid idGauchada);
    }
}