﻿using System;
using System.Collections.Generic;
using BlogDeFavores.Interfaces;
using BlogDeFavores.Models;

namespace BlogDeFavores.Services
{
    public class GauchadasService: IGauchadasService
    {
        private readonly IGauchadaDao _gauchadaDao;

        public GauchadasService(IGauchadaDao gauchadaDao)
        {
            _gauchadaDao = gauchadaDao;
        }

        public Gauchada GetById(Guid id)
        {
            return _gauchadaDao.GetById(id);
        }

        public List<Gauchada> GetByAutor(Guid id)
        {
            return _gauchadaDao.GetByAutor(id);
        }

        public List<Gauchada> GetByActor(Guid id)
        {
            return _gauchadaDao.GetByActor(id);
        }

        public Gauchada Registrar(Gauchada gauchada)
        {
            return _gauchadaDao.Registrar(gauchada);
        }

        public void RegistrarComentario(Guid id, Comentarios comentario)
        {
            _gauchadaDao.RegistrarComentario(id, comentario);
        }

        public void Eliminar(Guid id)
        {
            _gauchadaDao.Eliminar(id);
        }

        public void Editar(Guid id, Gauchada gauchada)
        {
            _gauchadaDao.Editar(id, gauchada);
        }

        public List<Gauchada> GetAll()
        {
            return _gauchadaDao.GetAll();
        }
    }
}