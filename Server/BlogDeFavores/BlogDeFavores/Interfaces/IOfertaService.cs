using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IOfertaService
    {
        Oferta Registrar(Oferta oferta);
        List<Oferta> GetByGauchadaId(Guid id);
        bool ValidateOffer(Guid usuarioId, Guid gauchadaId);
        void Editar(Guid id, Oferta oferta);
        void RechazarTodas(Guid idGauchada);
    }
}