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
            return context.Gauchadas.Where(x => x.AutorId == id).ToList();
        }

        public List<Gauchada> GetByActor(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RegistrarComentario(Guid id, Comentarios comentario)
        {
            Gauchada gauch = GetById(id);
            gauch.Comentarios.Add(comentario);
            context.Gauchadas.Update(gauch);
            context.SaveChanges();
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
            gauch.ActorId = gauchada.ActorId; //este es el que hizo la oferta
            gauch.AutorId = gauchada.AutorId;
            gauch.Descripcion = gauchada.Descripcion;
            gauch.Estado = gauchada.Estado;
            gauch.Titulo = gauchada.Titulo;
            gauch.Tipo = gauchada.Tipo;
            gauch.Localidad = gauchada.Localidad;
            gauch.Imagen = gauchada.Imagen;
            context.Gauchadas.Update(gauch);
            context.SaveChanges();
        }

        public List<Gauchada> GetAll()
        {
            return context.Gauchadas.ToList();
        }
    }
}