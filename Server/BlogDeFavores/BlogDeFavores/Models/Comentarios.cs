using System;

namespace BlogDeFavores.Models
{
    public class Comentarios
    {
        public Guid Id { get; set; }
        public string Texto { get; set; }
        public Usuario Autor { get; set; }
        public string Respuesta { get; set; }
    }
}