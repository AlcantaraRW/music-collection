using Alcantara.MusicCollection.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alcantara.MusicCollection.Infra.Configurations
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(u => u.Name)
                .IsRequired();

            builder.Property(u => u.Email)
                .IsRequired();

            builder.Property(u => u.Password)
                .IsRequired();

            builder.Property(u => u.AccessToken);

            builder.HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
