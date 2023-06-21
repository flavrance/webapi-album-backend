using AlbumApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumApp.Domain.Albuns
{
    public sealed class Midia : IEntity
    {
        public Guid Id { get; private set; }
        public Guid AlbumId { get; private set; }
        public string Caminho { get; private set; }
        public TipoMidiaEnum Tipo { get; private set; }
        public int Orderm { get; private set; }

        public Midia()
        {
            Id = Guid.NewGuid();
            Tipo = TipoMidiaEnum.CAPA;
        }

        public Midia(TipoMidiaEnum tipo)
        {
            Id = Guid.NewGuid();
            Tipo = tipo;  
        }
        public static Midia Load(Guid albumId, string caminho, TipoMidiaEnum tipo, int ordem){

            Midia midia = new Midia(tipo);
            midia.AlbumId = albumId;
            midia.Caminho = caminho;
            midia.Orderm = ordem;            
            return midia;
        }

        public static Midia Load(Guid id, Guid albumId, string caminho, TipoMidiaEnum tipo, int ordem)
        {

            Midia midia = new Midia();
            midia.Id = id;
            midia.AlbumId = albumId;
            midia.Caminho = caminho;
            midia.Tipo = tipo;
            midia.Orderm = ordem;
            return midia;
        }


    }
}
