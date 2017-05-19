using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class UsuarioController: Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost, Route("/api/usuario")]
        public Usuario RegistrarUsuario([FromBody] Usuario usuario)
        {
            return usuarioService.Registrar(usuario);   
        }

        [HttpDelete, Route("/api/usuario/{id}")]
        public void DeleteUsuario(Guid id)
        {
            usuarioService.Eliminar(id);
        }

        [HttpPut, Route("/api/usuario/{id}")]
        public void UpdateUpdate(Guid id, [FromBody] Usuario usuario)
        {
            usuarioService.Editar(id, usuario);
        }
    }
}