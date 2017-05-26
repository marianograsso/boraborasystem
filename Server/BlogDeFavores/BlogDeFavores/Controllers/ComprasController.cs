using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class ComprasController: Controller
    {
        private readonly IComprasService comprasService;

        public ComprasController(IComprasService comprasService)
        {
            this.comprasService = comprasService;
        }

        [HttpPost, Route("/api/compras")]
        public IActionResult RegistrarCompra([FromBody] Compras compra)
        {
            if (ModelState.IsValid)
            {
                return Ok(comprasService.Registrar(compra));
            }
            return BadRequest();
        }

    }
}