﻿// <auto-generated />
using System;
using Fulbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fulbo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230529205619_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fulbo.Domain.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Fulbo.Domain.Futbolista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Futbolistas");
                });

            modelBuilder.Entity("Fulbo.Domain.Goles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FutbolistaId")
                        .HasColumnType("int");

                    b.Property<int>("Minute")
                        .HasColumnType("int");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoJugador")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FutbolistaId");

                    b.HasIndex("PartidoId");

                    b.ToTable("Goles");
                });

            modelBuilder.Entity("Fulbo.Domain.Jugadores.JugadorLocal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<bool>("Firmado")
                        .HasColumnType("bit");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("PartidoId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("JugadoresLocal");
                });

            modelBuilder.Entity("Fulbo.Domain.Jugadores.JugadorVisitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<bool>("Firmado")
                        .HasColumnType("bit");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("PartidoId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("JugadoresVisitante");
                });

            modelBuilder.Entity("Fulbo.Domain.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Fulbo.Domain.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Fulbo.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NickName")
                        .IsUnique();

                    b.HasIndex("SessionId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Fulbo.Domain.Futbolista", b =>
                {
                    b.HasOne("Fulbo.Domain.Equipo", null)
                        .WithMany("Futbolistas")
                        .HasForeignKey("EquipoId");
                });

            modelBuilder.Entity("Fulbo.Domain.Goles", b =>
                {
                    b.HasOne("Fulbo.Domain.Futbolista", "Futbolista")
                        .WithMany()
                        .HasForeignKey("FutbolistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fulbo.Domain.Partido", null)
                        .WithMany("Goles")
                        .HasForeignKey("PartidoId");

                    b.Navigation("Futbolista");
                });

            modelBuilder.Entity("Fulbo.Domain.Jugadores.JugadorLocal", b =>
                {
                    b.HasOne("Fulbo.Domain.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fulbo.Domain.Partido", "Partido")
                        .WithOne("JugadorLocal")
                        .HasForeignKey("Fulbo.Domain.Jugadores.JugadorLocal", "PartidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fulbo.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Partido");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fulbo.Domain.Jugadores.JugadorVisitante", b =>
                {
                    b.HasOne("Fulbo.Domain.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fulbo.Domain.Partido", "Partido")
                        .WithOne("JugadorVisitante")
                        .HasForeignKey("Fulbo.Domain.Jugadores.JugadorVisitante", "PartidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fulbo.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Partido");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fulbo.Domain.User", b =>
                {
                    b.HasOne("Fulbo.Domain.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");
                });

            modelBuilder.Entity("Fulbo.Domain.Equipo", b =>
                {
                    b.Navigation("Futbolistas");
                });

            modelBuilder.Entity("Fulbo.Domain.Partido", b =>
                {
                    b.Navigation("Goles");

                    b.Navigation("JugadorLocal")
                        .IsRequired();

                    b.Navigation("JugadorVisitante")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
