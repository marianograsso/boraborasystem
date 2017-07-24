using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class CategoriaController: Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpPost, Route("/api/categoria/")]
        public IActionResult RegistrarCategoria([FromBody] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                var resp = _categoriaService.Registrar(categoria);
                if (resp == null)
                {
                    return BadRequest();
                }
                return Ok(resp);
            }
            return BadRequest();
        }

        [HttpGet, Route("/api/categoria/")]
        public IActionResult GetCategorias()
        {
            return Ok(_categoriaService.GetAll());
        }

    }
}
