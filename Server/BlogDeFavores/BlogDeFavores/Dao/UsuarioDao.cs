﻿using System;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Dao
{
    public class UsuarioDao: IUsuarioDao
    {
        private readonly UsuarioDbContext context;

        public UsuarioDao(UsuarioDbContext context)
        {
            this.context = context;
        }

        public Usuario Registrar(Usuario usuario)
        {
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
            context.Usuarios.Update(user);
            context.SaveChanges();
        }

        public Usuario GetById(Guid id)
        {
            return context.Usuarios.Find(id);
        }
    }
}