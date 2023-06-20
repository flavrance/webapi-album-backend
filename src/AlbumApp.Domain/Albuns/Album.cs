using AlbumApp.Domain.Tasks;
using AlbumApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumApp.Domain.Albuns
{
    public sealed class Album : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Guid ArtistaId { get; private set; }
        public Nome Nome { get; private set; }
        public int QuantidadeFaixas { get; private set; }
        public bool eDuplo { get; private set; }
        public Album() { 
            Id = Guid.NewGuid();
        }

        public static Album Load(Guid artistaId, Nome nome){

            Album album = new Album();
            album.ArtistaId = artistaId;
            album.Nome = nome;
            album.QuantidadeFaixas = 1;
            album.eDuplo = false;

            return album;
        }

        public static Album Load (Guid Id, Guid artistaId, Nome nome, int quantidadeFaixas, bool eDuplo) {
            Album album = new Album();
            album.Id = Id;
            album.ArtistaId = artistaId;
            album.Nome = nome;
            album.QuantidadeFaixas = quantidadeFaixas;
            album.eDuplo = eDuplo;

            return album;

        }
    }
}
