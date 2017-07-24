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
        public int Start { get; set; }  
    }

    
}