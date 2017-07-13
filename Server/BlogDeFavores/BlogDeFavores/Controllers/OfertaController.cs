using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class OfertaController: Controller
    {
        private readonly IOfertaService ofertaService;

        public OfertaController(IOfertaService ofertaService)
        {
            this.ofertaService = ofertaService;
        }

        [HttpPost, Route("/api/oferta")]
        public IActionResult RegistrarOferta([FromBody] Oferta oferta)
        {
            if (ModelState.IsValid)
            {
                return Ok(ofertaService.Registrar(oferta));
            }
            return BadRequest();
        }

        [HttpGet, Route("/api/oferta/validatoffer/{usuarioId}/{gauchadaId}")]
        public string ValidateOffer(Guid usuarioId, Guid gauchadaId)
        {
            if (ofertaService.ValidateOffer(usuarioId, gauchadaId))
            {
                return "Usuario registrado con exito";
            }
            return "El Email ya esta en uso";
        }

        [HttpGet, Route("/api/oferta/{id}")]
        public IActionResult GetByGauchadaId(Guid id)
        {
            if (ModelState.IsValid)
            {
                return Ok(ofertaService.GetByGauchadaId(id));
            }
            return BadRequest();
        }

        [HttpPut, Route("/api/oferta/{id}")]
        public void UpdateOferta(Guid id, [FromBody] Oferta oferta)
        {
            ofertaService.Editar(id, oferta);
        }

        [HttpPut, Route("/api/ofertas/{idGauchada}")]
        public void RechazarTodas(Guid idGauchada)
        {
            ofertaService.RechazarTodas(idGauchada);
        }
    }
}