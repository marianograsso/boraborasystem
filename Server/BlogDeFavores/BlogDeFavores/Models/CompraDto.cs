using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDeFavores.Models
{
    public class CompraDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TotalCreditos { get; set; }
        public int TotalPrecio { get; set; }
    }
}
