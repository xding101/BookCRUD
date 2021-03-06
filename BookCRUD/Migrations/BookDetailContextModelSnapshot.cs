﻿// <auto-generated />
using BookCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookCRUD.Migrations
{
    [DbContext(typeof(BookDetailContext))]
    partial class BookDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookCRUD.Models.BookDetail", b =>
                {
                    b.Property<int>("BKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BKID");

                    b.ToTable("BookDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
