using System;
using System.ComponentModel.DataAnnotations;

namespace BlogDeFavores.Models
{
    public class Compras
    {
        public Guid Id { get; set; }
        public Guid IdComprador { get; set; }
        [Required]
        public int CantCreditos { get; set; }
        [Required]
        public int Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}