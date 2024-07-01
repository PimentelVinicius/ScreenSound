﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScreenSound.Banco;

#nullable disable

namespace ScreenSound.Migrations
{
    [DbContext(typeof(ScreenSoundContext))]
    [Migration("20240627222630_AlteracaoDeNullParaBandaNome")]
    partial class AlteracaoDeNullParaBandaNome
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ScreenSound.Modelos.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<string>("AlbumNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BandaId")
                        .HasColumnType("int");

                    b.HasKey("AlbumId");

                    b.HasIndex("BandaId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("ScreenSound.Modelos.AlbumAvaliacao", b =>
                {
                    b.Property<int>("AlbumAvaliacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumAvaliacaoId"));

                    b.Property<int>("AlbumAvaliacaoNota")
                        .HasColumnType("int");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.HasKey("AlbumAvaliacaoId");

                    b.HasIndex("AlbumId");

                    b.ToTable("AlbumAvaliacao");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Banda", b =>
                {
                    b.Property<int>("BandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BandaId"));

                    b.Property<string>("BandaNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BandaId");

                    b.ToTable("Banda");
                });

            modelBuilder.Entity("ScreenSound.Modelos.AlbumAvaliacao", b =>
                {
                    b.Property<int>("BandaAvaliacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BandaAvaliacaoId"));

                    b.Property<int>("BandaAvaliacaoNota")
                        .HasColumnType("int");

                    b.Property<int>("BandaId")
                        .HasColumnType("int");

                    b.Property<string>("BandaNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BandaAvaliacaoId");

                    b.HasIndex("BandaId");

                    b.ToTable("AlbumAvaliacao");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int?>("AnoLancamento")
                        .HasColumnType("int");

                    b.Property<int?>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<string>("MusicaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Musicas");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Album", b =>
                {
                    b.HasOne("ScreenSound.Modelos.Banda", "Banda")
                        .WithMany("Albuns")
                        .HasForeignKey("BandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banda");
                });

            modelBuilder.Entity("ScreenSound.Modelos.AlbumAvaliacao", b =>
                {
                    b.HasOne("ScreenSound.Modelos.Album", "album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("album");
                });

            modelBuilder.Entity("ScreenSound.Modelos.AlbumAvaliacao", b =>
                {
                    b.HasOne("ScreenSound.Modelos.Banda", "Banda")
                        .WithMany("Notas")
                        .HasForeignKey("BandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banda");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Musica", b =>
                {
                    b.HasOne("ScreenSound.Modelos.Album", null)
                        .WithMany("Musicas")
                        .HasForeignKey("AlbumId");

                    b.HasOne("ScreenSound.Modelos.Artista", "Artista")
                        .WithMany("Musicas")
                        .HasForeignKey("ArtistaId");

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Album", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Artista", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("ScreenSound.Modelos.Banda", b =>
                {
                    b.Navigation("Albuns");

                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
