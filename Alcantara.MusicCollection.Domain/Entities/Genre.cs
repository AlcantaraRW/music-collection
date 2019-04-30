using System.Collections.Generic;

namespace Alcantara.MusicCollection.Domain.Entities
{
    public class Genre : BaseEntity
    {
        private readonly ICollection<TitleGenre> _titleGenres;

        public string Name { get; private set; }
        public IEnumerable<TitleGenre> TitleGenres => _titleGenres;

        public Genre(string name)
        {
            Name = name;
        }
    }
}
