using System;

namespace BlogDeFavores.Models
{
    public class Oferta
    {
        public Guid Id { get; set; }
        public Guid IdOfertador { get; set; }
        public Status Estado { get; set; }
        public Calificacion Calificacion { get; set; }
    }

    public enum Status
    {
        Pendiente = 2,
        Aceptada = 1,
        Rechazada = 0
    }
}