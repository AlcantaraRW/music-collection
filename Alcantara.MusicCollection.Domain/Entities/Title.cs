using System.Collections.Generic;

namespace Alcantara.MusicCollection.Domain.Entities
{
    public class Title : BaseEntity
    {
        private readonly ICollection<TitleGenre> _titleGenres;

        public string Name { get; private set; }
        public int Year { get; private set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public IEnumerable<TitleGenre> TitleGenres => _titleGenres;

        private Title()
        {
        }

        public Title(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
