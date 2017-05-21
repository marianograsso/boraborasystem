using System;
using System.Collections.Generic;

namespace BlogDeFavores.Models
{
    public class Gauchada
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string Localidad { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Comentarios> Comentarios { get; set; }
        public Guid AutorId { get; set; }
        public Guid ActorId { get; set; }
    }
}