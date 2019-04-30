using Alcantara.MusicCollection.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alcantara.MusicCollection.Infra.Configurations
{
    public class TitleConfiguration : BaseConfiguration<Title>
    {
        public override void Configure(EntityTypeBuilder<Title> builder)
        {
            base.Configure(builder);

            builder.Property(t => t.Name)
                .IsRequired();

            builder.Property(t => t.Year)
                .IsRequired();

            builder.HasOne(t => t.Artist)
                .WithMany(a => a.Titles)
                .HasForeignKey(t => t.ArtistId);
        }
    }
}
