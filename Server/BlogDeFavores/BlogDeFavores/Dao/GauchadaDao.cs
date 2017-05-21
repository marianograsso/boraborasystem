using System;
using System.Collections.Generic;
using System.Linq;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Dao
{
    public class GauchadaDao: IGauchadaDao
    {
        private readonly GauchadaDbContext context;

        public GauchadaDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Gauchada GetById(Guid id)
        {
            return context.Gauchadas.Find(id);
        }

        public List<Gauchada> GetByAutor(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Gauchada> GetByActor(Guid id)
        {
            throw new NotImplementedException();
        }

        public Gauchada Registrar(Gauchada gauchada)
        {
            context.Gauchadas.Add(gauchada);
            context.SaveChanges();
            return gauchada;
        }

        public void Eliminar(Guid id)
        {
            Gauchada gauchada = GetById(id);
            context.Gauchadas.Remove(gauchada);
            context.SaveChanges();
        }

        public void Editar(Guid id, Gauchada gauchada)
        {
            Gauchada gauch = GetById(id);
            gauch.ActorId = gauchada.ActorId;
            gauch.AutorId = gauchada.AutorId;
            gauch.Descripcion = gauchada.Descripcion;
            context.Gauchadas.Update(gauch);
            context.SaveChanges();
        }
    }
}