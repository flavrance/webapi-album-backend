using AlbumApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumApp.Domain.Albuns
{
    public sealed class Faixa
    {        
        public Guid AlbumId { get; private set; }
        public Guid MusicaId { get; private set; }
        public int Indice { get; private set; }        

        public Faixa()
        {
            Indice = 1;
        }
        public static Faixa Load(Guid albumId, Guid musicaId){

            Faixa faixa = new Faixa();
            faixa.AlbumId = albumId;
            faixa.MusicaId = musicaId;            
            
            return faixa;
        }

        public static Faixa Load(Guid albumId, Guid musicaId, int indice)
        {

            Faixa faixa = new Faixa();
            faixa.AlbumId = albumId;
            faixa.MusicaId = musicaId;
            faixa.Indice = indice;

            return faixa;
        }


    }
}
