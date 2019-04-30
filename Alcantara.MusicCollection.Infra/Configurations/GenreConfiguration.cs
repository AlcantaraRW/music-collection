using Alcantara.MusicCollection.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alcantara.MusicCollection.Infra.Configurations
{
    public class GenreConfiguration : BaseConfiguration<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            base.Configure(builder);

            builder.Property(g => g.Name)
                .IsRequired();
        }
    }
}
