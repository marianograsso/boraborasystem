﻿using System;
using System.Collections.Generic;
using BlogDeFavores.Models;

namespace BlogDeFavores.Interfaces
{
    public interface IGauchadaDao
    {
        void RegistrarComentario(Guid id, Comentarios comentario);
        Gauchada GetById(Guid id);
        List<Gauchada> GetByAutor(Guid id);
        List<Gauchada> GetByActor(Guid id);
        Gauchada Registrar(Gauchada gauchada);
        void Eliminar(Guid id);
        void Editar(Guid id, Gauchada gauchada);
        List<Gauchada> GetAll();
    }
}