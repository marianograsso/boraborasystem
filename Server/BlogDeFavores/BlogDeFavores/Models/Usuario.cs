using System;
using System.Collections.Generic;

namespace BlogDeFavores.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int Puntaje { get; set; }
        public Categoria Categoria { get; set; }
        public List<Gauchada> GauchadasRealizadas { get; set; }
        public List<Gauchada> GauchadasIniciadas { get; set; }
        public int Credito { get; set; }
    }

    public class Administrador : Usuario
    {
    }
}