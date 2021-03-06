﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioDao usuarioDao;

        public UsuarioService(IUsuarioDao usuarioDao)
        {
            this.usuarioDao = usuarioDao;
        }

        public Usuario Registrar(Usuario usuario)
        {
            return usuarioDao.Registrar(usuario);
        }

        public void Eliminar(Guid id)
        {
            usuarioDao.Eliminar(id);
        }

        public void Editar(Guid id, Usuario usuario)
        {
            usuarioDao.Editar(id, usuario);
        }

        public Usuario GetById(Guid id)
        {
            return usuarioDao.GetById(id);
        }

        public Usuario GetByEmailyPassword(string email, string password)
        {
            return usuarioDao.GetByEmailyPassword(email, password);
        }

        public bool ValidateEmail(string email)
        {
            return usuarioDao.ValidateEmail(email);
        }

        public List<object> GetRankings()
        {
            return usuarioDao.GetRankings();
        }

        public List<object> GetCompras()
        {
            return usuarioDao.GetCompras();
        }
    }
}