﻿// <auto-generated />
using Alcantara.MusicCollection.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alcantara.MusicCollection.Infra.Migrations
{
    [DbContext(typeof(MusicCollectionContext))]
    [Migration("20190430010224_TableGenresCreated")]
    partial class TableGenresCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alcantara.MusicCollection.Domain.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Alcantara.MusicCollection.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Alcantara.MusicCollection.Domain.Entities.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Alcantara.MusicCollection.Domain.Entities.Title", b =>
                {
                    b.HasOne("Alcantara.MusicCollection.Domain.Entities.Artist", "Artist")
                        .WithMany("Titles")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
