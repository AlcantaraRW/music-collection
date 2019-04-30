using System.Collections.Generic;

namespace Alcantara.MusicCollection.Domain.Entities
{
    public class Artist : BaseEntity
    {
        private readonly ICollection<Title> _titles;

        public string Name { get; private set; }
        public IEnumerable<Title> Titles => _titles;

        private Artist()
        {
        }

        public Artist(string name)
        {
            Name = name;

            _titles = new List<Title>();
        }
    }
}
