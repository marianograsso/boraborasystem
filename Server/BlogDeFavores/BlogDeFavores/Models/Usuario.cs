using System;
using System.Collections.Generic;

namespace BlogDeFavores.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int Puntaje { get; set; }
        public string Avatar { get; set; }
        public Categoria Categoria { get; set; }
        public List<Oferta> OfertasRealizadas { get; set; }
        public List<Gauchada> GauchadasIniciadas { get; set; }
        public int Credito { get; set; }
        public List<Compras> ComprasRealizadas { get; set; }
    }

    public class Administrador : Usuario
    {
    }
}