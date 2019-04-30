namespace Alcantara.MusicCollection.Domain.Entities
{
    public class TitleGenre
    {
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
