using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly IComentarioService comentarioService;

        public ComentariosController(IComentarioService comentarioService)
        {
            this.comentarioService = comentarioService;
        }

        [HttpPost, Route("/api/comentario")]
        public IActionResult RegistrarComentario([FromBody] Comentarios comentario)
        {
            if (ModelState.IsValid)
            {
                return Ok(comentarioService.Registrar(comentario));
            }
            return BadRequest();
        }

        [HttpGet, Route("/api/comentario/{id}")]
        public IActionResult GetAll(Guid id)
        {
            if (ModelState.IsValid)
            {
                return Ok(comentarioService.GetAll(id));
            }
            return BadRequest();
        }   

        [HttpPut, Route("/api/comentario/{id}")]
        public IActionResult Update(Guid id, [FromBody] Comentarios comentario)
        {
            comentarioService.Update(id, comentario);
            return Ok();
        }
    }
}