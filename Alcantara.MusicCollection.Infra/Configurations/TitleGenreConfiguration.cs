using Alcantara.MusicCollection.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alcantara.MusicCollection.Infra.Configurations
{
    public class TitleGenreConfiguration : IEntityTypeConfiguration<TitleGenre>
    {
        public void Configure(EntityTypeBuilder<TitleGenre> builder)
        {
            builder.HasKey(tg => new { tg.TitleId, tg.GenreId });

            builder.HasOne(tg => tg.Title)
                .WithMany(t => t.TitleGenres)
                .HasForeignKey(tg => tg.TitleId);

            builder.HasOne(tg => tg.Genre)
                .WithMany(g => g.TitleGenres)
                .HasForeignKey(tg => tg.GenreId);
        }
    }
}
