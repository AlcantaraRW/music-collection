using Alcantara.MusicCollection.Infra.Configurations;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Alcantara.MusicCollection.Infra.Context
{
    public class MusicCollectionContext : DbContext
    {
        public MusicCollectionContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
