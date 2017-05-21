using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogDeFavores.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public Range Rango { get; set; }
    }

    public class Range
    {
        public Guid Id { get; set; }
        int Start { get; set; }
        int End { get; set; }
    }
    
}