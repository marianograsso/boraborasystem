using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace BlogDeFavores.Dao
{
    public class UsuarioDao : IUsuarioDao
    {
        private readonly GauchadaDbContext context;

        public UsuarioDao(GauchadaDbContext context)
        {
            this.context = context;
        }

        public Usuario Registrar(Usuario usuario)
        {
            usuario.Avatar = @"images/avatar.png";
            //usuario.Categoria = new Categoria()
            //{

            //};
            context.Usuarios.Add(usuario);

            context.SaveChanges();
            return usuario;
        }

        public void Eliminar(Guid id)
        {
            Usuario usuario = GetById(id);
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }

        public void Editar(Guid id, Usuario usuario)
        {
            Usuario user = GetById(id);
            user.Nombre = usuario.Nombre;
            user.Apellido = usuario.Apellido;
            user.Avatar = usuario.Avatar;
            user.Telefono = usuario.Telefono;
            user.Password = usuario.Password;
            user.Credito = usuario.Credito;
            user.Email = usuario.Email;
            user.Puntaje = usuario.Puntaje;
            context.Usuarios.Update(user);
            context.SaveChanges();
        }

        public Usuario GetById(Guid id)
        {
            return context.Usuarios.Find(id);
        }

        public Usuario GetByEmailyPassword(string email, string password)
        {
            return context.Usuarios.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public bool ValidateEmail(string email)
        {
            var valor = context.Usuarios.FirstOrDefault(x => x.Email == email);
            // si no me trajo nada, es porque no existe ese usuario
            if (valor == null)
            {
                return true;
            }
            return false;
        }

        public List<object> GetRankings()
        {
            //aca tiene que ir la query

            /*
             * SELECT u2.id, u2.nombre, u2.apellido, u2.puntaje, c2.nombre
                FROM [Ing2].[dbo].[Usuario] u2 
                INNER JOIN [Ing2].[dbo].[Categorias] c2 ON (c2.Start <= u2.Puntaje)
                INNER JOIN 
                 (SELECT u.id, u.nombre, u.apellido, u.puntaje, MAX(c.Start) as Start
                 FROM [Ing2].[dbo].[Usuario] u INNER JOIN [Ing2].[dbo].[Categorias] c ON (c.Start <=  u.Puntaje)
                 GROUP BY u.id, u.nombre, u.apellido, u.puntaje) 
                 rank ON rank.id = u2.id AND c2.Start = rank.Start
             */
            
            return null;
        }

        public List<object> GetCompras()
        {
            // aca tiene que ir la query
            /*
             * SELECT u.id, u.nombre, u.apellido, SUM(c.CantCreditos) as creditos, SUM(c.precio) as total
                FROM [Ing2].[dbo].[Usuario] u INNER JOIN [Ing2].[dbo].[Compras] c ON (u.id=c.idcomprador)
                WHERE MONTH(c.Fecha) = 07
                GROUP BY u.id, u.nombre, u.apellido
             */
            return null;
        }

        public List<Usuario> GetAll()
        {
            return context.Usuarios.ToList();
        }
    }
}