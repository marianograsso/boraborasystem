using System;

namespace BlogDeFavores.Models
{
    public class Calificacion
    {
        public Guid Id { get; set; }
        public Puntaje Puntaje { get; set; }
        public string Texto { get; set; }
    }

    public enum Puntaje
    {
        Positivo = 1,
        Neutro = 2,
        Negativo = 0
    }
}