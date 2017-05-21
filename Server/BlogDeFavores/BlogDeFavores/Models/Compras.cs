using System;

namespace BlogDeFavores.Models
{
    public class Compras
    {
        public Guid Id { get; set; }
        public Guid IdComprador { get; set; }
        public int CantCreditos { get; set; }
        public int Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}