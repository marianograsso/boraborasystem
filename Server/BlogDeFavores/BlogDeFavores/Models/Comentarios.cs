using System;
using System.ComponentModel.DataAnnotations;

namespace BlogDeFavores.Models
{
    public class Comentarios
    {
        public Guid Id { get; set; }
        [Required]
        public string Texto { get; set; }
        public Guid GauchadaId { get; set; }
        public string NombreAutor { get; set; }
        public string Respuesta { get; set; }
    }
}