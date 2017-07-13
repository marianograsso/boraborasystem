using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class CalificacionController: Controller
    {
        private readonly ICalificacionService calificacionService;

        public CalificacionController(ICalificacionService calificacionService)
        {
            this.calificacionService = calificacionService;
        }

        [HttpPost, Route("/api/calificacion")]
        public IActionResult RegistrarCalificacion([FromBody] Calificacion calificacion)
        {
            if (ModelState.IsValid)
            {
                return Ok(calificacionService.Registrar(calificacion));
            }
            return BadRequest();
        }
    }
}
