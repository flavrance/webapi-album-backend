using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumApp.Domain.Albuns
{
    public sealed class Musica : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
    }
}
