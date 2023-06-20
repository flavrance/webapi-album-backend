namespace AlbumApp.Domain.Tasks
{
    using TaskApp.Domain.ValueObjects;
    using System;
    using System.Collections.Generic;
    using System.Transactions;
    using AlbumApp.Domain.ValueObjects;

    public sealed class Artista : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }        
        public Nome Nome { get; private set; }        
        public Artista() {
            Id = Guid.NewGuid();
        }        
        public static Artista Load(Nome nome)
        {
            Artista artista = new Artista();            
            artista.Nome = nome;            
            return artista;
        }
        public static Artista Load(Guid id, Nome nome)
        {
            Artista artista = new Artista();
            artista.Id = id;            
            artista.Nome = nome;            
            return artista;
        }
    }
}
