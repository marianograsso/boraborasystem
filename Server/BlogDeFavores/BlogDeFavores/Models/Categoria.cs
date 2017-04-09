using System;

namespace BlogDeFavores.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public int Rango { get; set; }
    }
}