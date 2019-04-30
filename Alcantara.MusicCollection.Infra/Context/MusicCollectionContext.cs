using Alcantara.MusicCollection.Domain.Entities;
using Alcantara.MusicCollection.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Alcantara.MusicCollection.Infra.Context
{
    public class MusicCollectionContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TitleGenre> TitleGenres { get; set; }

        public MusicCollectionContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new TitleGenreConfiguration());
        }
    }
}
