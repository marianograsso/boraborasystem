using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogDeFavores.Controllers
{
    public class GauchadaController: Controller
    {
        private readonly IGauchadasService gauchadasService;

        public GauchadaController(IGauchadasService gauchadasService)
        {
            this.gauchadasService = gauchadasService;
        }

        [HttpPost, Route("/api/gauchada")]
        public Gauchada RegistrarGauchada([FromBody] Gauchada gauchada)
        {
            return gauchadasService.Registrar(gauchada);
        }

        [HttpDelete, Route("/api/gauchada/{id}")]
        public void DeleteGauchada(Guid id)
        {
            gauchadasService.Eliminar(id);
        }

        [HttpPut, Route("/api/gauchada/{id}")]
        public void UpdateGauchada(Guid id, [FromBody] Gauchada gauchada)
        {
            gauchadasService.Editar(id, gauchada);
        }
    }
}