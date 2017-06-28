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
    }
}