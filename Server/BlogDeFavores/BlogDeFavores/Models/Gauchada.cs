using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogDeFavores.Models
{
    public class Gauchada
    {
        public Guid Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        [Required]
        public string Localidad { get; set; }
        [Required]
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        public List<Comentarios> Comentarios { get; set; }
        public List<Oferta> Oferta { get; set; }
        public string Autor { get; set; }
        public Guid AutorId { get; set; }
        public Guid ActorId { get; set; }
        public Status Estado { get; set; }
    }


}

