﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Datos;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Author_Libros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("Author_LibrosId")
                        .HasColumnType("int");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("Author_LibrosId");

                    b.HasIndex("IdLibro");

                    b.ToTable("Author_Libro");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.LibrosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Author_Libros", b =>
                {
                    b.HasOne("WebApplication1.Datos.Modelos.Author", "Author")
                        .WithMany("Author_Libros")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Datos.Modelos.Author_Libros", null)
                        .WithMany("Author_Libross")
                        .HasForeignKey("Author_LibrosId");

                    b.HasOne("WebApplication1.Datos.Modelos.LibrosModel", "libros")
                        .WithMany("Author_Libros")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("libros");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.LibrosModel", b =>
                {
                    b.HasOne("WebApplication1.Datos.Modelos.Publisher", "Publisher")
                        .WithMany("Libros")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Author", b =>
                {
                    b.Navigation("Author_Libros");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Author_Libros", b =>
                {
                    b.Navigation("Author_Libross");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.LibrosModel", b =>
                {
                    b.Navigation("Author_Libros");
                });

            modelBuilder.Entity("WebApplication1.Datos.Modelos.Publisher", b =>
                {
                    b.Navigation("Libros");
                });
#pragma warning restore 612, 618
        }
    }
}
