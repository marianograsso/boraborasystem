using System;
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

        public void GetById(Guid id)
        {
            _gauchadaDao.GetById(id);
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

        public void Eliminar(Guid id)
        {
            _gauchadaDao.Eliminar(id);
        }

        public void Editar(Guid id, Gauchada gauchada)
        {
            _gauchadaDao.Editar(id, gauchada);
        }
    }
}