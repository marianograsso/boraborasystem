namespace BlogDeFavores.Models
{
    public class Oferta
    {
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