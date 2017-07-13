using System;
using System.Collections.Generic;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public IActionResult RegistrarGauchada([FromBody] Gauchada gauchada)
        {
            if (ModelState.IsValid)
            {
                return Ok(gauchadasService.Registrar(gauchada));
            }
            return BadRequest();
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

        [HttpGet, Route("/api/gauchada/{id}")]
        public IActionResult GetGauchada(Guid id)
        {
            return Ok(gauchadasService.GetById(id));
        }

        [HttpGet, Route("/api/gauchada/")]
        public IActionResult GetGauchadas()
        {
            return Ok(gauchadasService.GetAll());
        }

    }
}