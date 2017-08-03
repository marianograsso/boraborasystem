using System;
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

        [HttpGet, Route("/api/categoria/{start}")]
        public IActionResult GetCategoriaByStart(int start)
        {
            return Ok(_categoriaService.GetCategoriaByStart(start));
        }

        [HttpDelete, Route("/api/categoria/{id}")]
        public void DeleteCategoria(Guid id)
        {
            _categoriaService.Eliminar(id);
        }

        [HttpGet, Route("/api/categoria/all/")]
        public IActionResult GetRankings()
        {
            return Ok(_categoriaService.GetRanking());
        }


        [HttpPut, Route("/api/categoria/{id}")]
        public IActionResult UpdateCategoria(Guid id, [FromBody] Categoria categoria)
        {

            if (ModelState.IsValid)
            {
                var resp = _categoriaService.Editar(id, categoria);
                if (resp == null)
                {
                    return BadRequest();
                }
                return Ok(resp);
            }
            return BadRequest();
        }

    }
}
