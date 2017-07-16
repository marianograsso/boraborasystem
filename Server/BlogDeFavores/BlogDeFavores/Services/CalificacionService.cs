using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class CalificacionService: ICalificacionService
    {
        private readonly ICalifacionDao calificacionDao;

        public CalificacionService(ICalifacionDao calificacionDao)
        {
            this.calificacionDao = calificacionDao;
        }

        public Calificacion Registrar(Calificacion calificacion)
        {
            return calificacionDao.Registrar(calificacion);
        }

        public Calificacion GetById(Guid id)
        {
            return calificacionDao.GetById(id);
        }
    }
}
