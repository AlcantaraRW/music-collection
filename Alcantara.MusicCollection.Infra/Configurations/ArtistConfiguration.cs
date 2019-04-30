using Alcantara.MusicCollection.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alcantara.MusicCollection.Infra.Configurations
{
    public class ArtistConfiguration : BaseConfiguration<Artist>
    {
        public override void Configure(EntityTypeBuilder<Artist> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.Name)
                .IsRequired();
        }
    }
}
