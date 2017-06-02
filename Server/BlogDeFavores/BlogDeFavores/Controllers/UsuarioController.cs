using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogDeFavores.Controllers
{
    public class UsuarioController: Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet, Route("/api/usuario/{email}/{password}")]
        public IActionResult GetUsuario(string email, string password)
        {
            return Ok(usuarioService.GetByEmailyPassword(email, password));
        }

        [HttpGet, Route("/api/usuario/validatemail/{email}")]
        public string ValidateEmail(string email)
        {
            if (usuarioService.ValidateEmail(email))
            {
                return "Usuario registrado con exito";
            }
            return "El Email ya esta en uso";
        }

        [HttpGet, Route("/api/usuario/")]
        public string GetUsuario()
        {
            return "asd";
        }

        [HttpPost, Route("/api/usuario")]
        public IActionResult RegistrarUsuario([FromBody] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return Ok(usuarioService.Registrar(usuario));
            }
            return BadRequest();
        }

        [HttpDelete, Route("/api/usuario/{id}")]
        public void DeleteUsuario(Guid id)
        {
            usuarioService.Eliminar(id);
        }

        [HttpPut, Route("/api/usuario/{id}")]
        public void UpdateUsuario(Guid id, [FromBody] Usuario usuario)
        {
            usuarioService.Editar(id, usuario);
        }
    }
}