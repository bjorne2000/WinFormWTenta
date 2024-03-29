﻿// <auto-generated />
using System;
using BackendWinFormTenta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendWinFormTenta.Migrations
{
    [DbContext(typeof(DbContextMovie))]
    [Migration("20210520110011_removeBiljett")]
    partial class removeBiljett
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackendWinFormTenta.Bokning", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("bokadKundID")
                        .HasColumnType("int");

                    b.Property<int?>("bokadVisningID")
                        .HasColumnType("int");

                    b.Property<string>("platser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("bokadKundID");

                    b.HasIndex("bokadVisningID");

                    b.ToTable("bokningar");
                });

            modelBuilder.Entity("BackendWinFormTenta.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("filmNamn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("filmer");
                });

            modelBuilder.Entity("BackendWinFormTenta.Kund", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("namn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("perssonNr")
                        .HasColumnType("int");

                    b.Property<string>("teleNr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("kunder");
                });

            modelBuilder.Entity("BackendWinFormTenta.Salong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("plats1")
                        .HasColumnType("bit");

                    b.Property<bool>("plats10")
                        .HasColumnType("bit");

                    b.Property<bool>("plats11")
                        .HasColumnType("bit");

                    b.Property<bool>("plats12")
                        .HasColumnType("bit");

                    b.Property<bool>("plats13")
                        .HasColumnType("bit");

                    b.Property<bool>("plats14")
                        .HasColumnType("bit");

                    b.Property<bool>("plats15")
                        .HasColumnType("bit");

                    b.Property<bool>("plats16")
                        .HasColumnType("bit");

                    b.Property<bool>("plats17")
                        .HasColumnType("bit");

                    b.Property<bool>("plats18")
                        .HasColumnType("bit");

                    b.Property<bool>("plats19")
                        .HasColumnType("bit");

                    b.Property<bool>("plats2")
                        .HasColumnType("bit");

                    b.Property<bool>("plats20")
                        .HasColumnType("bit");

                    b.Property<bool>("plats3")
                        .HasColumnType("bit");

                    b.Property<bool>("plats4")
                        .HasColumnType("bit");

                    b.Property<bool>("plats5")
                        .HasColumnType("bit");

                    b.Property<bool>("plats6")
                        .HasColumnType("bit");

                    b.Property<bool>("plats7")
                        .HasColumnType("bit");

                    b.Property<bool>("plats8")
                        .HasColumnType("bit");

                    b.Property<bool>("plats9")
                        .HasColumnType("bit");

                    b.Property<int>("salongNum")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("salonger");
                });

            modelBuilder.Entity("BackendWinFormTenta.Visning", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime2");

                    b.Property<int?>("visningsFilmID")
                        .HasColumnType("int");

                    b.Property<int?>("visningsSalongID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("visningsFilmID");

                    b.HasIndex("visningsSalongID");

                    b.ToTable("visningar");
                });

            modelBuilder.Entity("BackendWinFormTenta.Bokning", b =>
                {
                    b.HasOne("BackendWinFormTenta.Kund", "bokadKund")
                        .WithMany()
                        .HasForeignKey("bokadKundID");

                    b.HasOne("BackendWinFormTenta.Visning", "bokadVisning")
                        .WithMany()
                        .HasForeignKey("bokadVisningID");

                    b.Navigation("bokadKund");

                    b.Navigation("bokadVisning");
                });

            modelBuilder.Entity("BackendWinFormTenta.Visning", b =>
                {
                    b.HasOne("BackendWinFormTenta.Film", "visningsFilm")
                        .WithMany()
                        .HasForeignKey("visningsFilmID");

                    b.HasOne("BackendWinFormTenta.Salong", "visningsSalong")
                        .WithMany()
                        .HasForeignKey("visningsSalongID");

                    b.Navigation("visningsFilm");

                    b.Navigation("visningsSalong");
                });
#pragma warning restore 612, 618
        }
    }
}
