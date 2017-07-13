using System;
using System.Collections.Generic;
using System.Linq;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Dao
{
    public class ComentarioDao: IComentarioDao
    {
        private readonly GauchadaDbContext context;

        public ComentarioDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Comentarios Registrar(Comentarios comentario)
        {
            context.Comentarios.Add(comentario);
            context.SaveChanges();
            return comentario;
        }

        public List<Comentarios> GetAll(Guid id)
        {
            var comentarioses = new List<Comentarios>(context.Comentarios.Where(x => x.GauchadaId == id));
            return comentarioses;
        }

        public Comentarios GetById(Guid id)
        {
            return context.Comentarios.Find(id);
        }

        public void Update(Guid id, Comentarios comentario)
        {
            Comentarios coment = GetById(id);
            coment.Respuesta = comentario.Respuesta;
            context.Comentarios.Update(coment);
            context.SaveChanges();
        }
    }
}
