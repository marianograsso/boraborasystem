using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using BlogDeFavores.Services;

namespace BlogDeFavores.Dao
{
    public class CalificacionDao: ICalifacionDao
    {
        private readonly GauchadaDbContext context;

        public CalificacionDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Calificacion Registrar(Calificacion calificacion)
        {
            context.Calificaciones.Add(calificacion);
            context.SaveChanges();
            return calificacion;
        }

        public Calificacion GetById(Guid id)
        {
            return context.Calificaciones.Find(id);
        }
    }
}
