using Alcantara.MusicCollection.Domain.Interfaces;

namespace Alcantara.MusicCollection.Domain.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
