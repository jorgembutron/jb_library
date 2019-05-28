﻿// <auto-generated />
using System;
using Jb.Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jb.Api.Infrastructure.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20190522184712_updateCols2")]
    partial class updateCols2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jb.Api.Domain.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<DateTimeOffset>("DateOfBirth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Jb.Api.Domain.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("PublishedOn");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Jb.Api.Domain.BookAuthor", b =>
                {
                    b.Property<Guid>("BookId");

                    b.Property<Guid>("AuthorId");

                    b.Property<byte>("Order");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("Jb.Api.Domain.PriceOffer", b =>
                {
                    b.Property<Guid>("PriceOfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<Guid>("BookId");

                    b.Property<decimal>("NewPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("PromotionalText");

                    b.HasKey("PriceOfferId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("PriceOffers");
                });

            modelBuilder.Entity("Jb.Api.Domain.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<Guid>("BookId");

                    b.Property<string>("Comment");

                    b.Property<int>("NumStars");

                    b.Property<string>("VoterName");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Jb.Api.Domain.BookAuthor", b =>
                {
                    b.HasOne("Jb.Api.Domain.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Jb.Api.Domain.Book", "Book")
                        .WithMany("AuthorsLink")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jb.Api.Domain.PriceOffer", b =>
                {
                    b.HasOne("Jb.Api.Domain.Book")
                        .WithOne("Promotion")
                        .HasForeignKey("Jb.Api.Domain.PriceOffer", "BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Jb.Api.Domain.Review", b =>
                {
                    b.HasOne("Jb.Api.Domain.Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}