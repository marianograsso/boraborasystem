using System;
using System.Collections.Generic;

namespace BlogDeFavores.Models
{
    public class Gauchada
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public string Categoria { get; set; }
        public List<Comentarios> Comentarios { get; set; }
        public Usuario Autor { get; set; }
        public Usuario Actor { get; set; }
    }
}