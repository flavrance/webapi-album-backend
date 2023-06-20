namespace AlbumApp.Domain.Tasks
{
    using AlbumApp.Domain.ValueObjects;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public sealed class ArtistaCollection
    {
        private readonly IList<Artista> _artistas;

        public ArtistaCollection()
        {
            _artistas = new List<Artista>();
        }

        public IReadOnlyCollection<Artista> GetArtistas()
        {
            IReadOnlyCollection<Artista> artistas = new ReadOnlyCollection<Artista>(_artistas);
            return artistas;
        }
        public Artista GetUltimaArtista()
        {
            Artista artista = _artistas[_artistas.Count - 1];
            return artista;
        }

        public void Add(Artista artista)
        {
            _artistas.Add(artista);
        }

        public void Add(IEnumerable<Artista> artistas)
        {
            foreach (var artista in artistas)
            {
                Add(artista);
            }
        }               
    }
}
