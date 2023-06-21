using AlbumApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumApp.Domain.Albuns
{
    public sealed class Musica : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Guid ArtistaId { get; private set; }
        public Nome Nome { get; private set; }
        public Nome Compositor { get; private set; }

        public Musica()
        {
            Id = Guid.NewGuid();
        }
        public static Musica Load(Guid artistaId, Nome nome, Nome compositor){

            Musica musica = new Musica();
            musica.ArtistaId = artistaId;
            musica.Nome = nome;
            musica.Compositor = compositor;
            
            return musica;
        }

        public static Musica Load(Guid id, Guid artistaId, Nome nome, Nome compositor)
        {

            Musica musica = new Musica();
            musica.Id = id;
            musica.ArtistaId = artistaId;
            musica.Nome = nome;
            musica.Compositor = compositor;

            return musica;
        }


    }
}
