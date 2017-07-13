using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace BlogDeFavores.Dao
{
    public class UsuarioDao: IUsuarioDao
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
    }
}