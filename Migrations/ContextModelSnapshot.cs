﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektMS.Models;

namespace ProjektMS.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("GryProducent", b =>
                {
                    b.Property<int>("GryId")
                        .HasColumnType("int");

                    b.Property<int>("ProducentId")
                        .HasColumnType("int");

                    b.HasKey("GryId", "ProducentId");

                    b.HasIndex("ProducentId");

                    b.ToTable("GryProducent");
                });

            modelBuilder.Entity("projekt.Models.Cena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cenaa")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("Id");

                    b.ToTable("Cena");
                });

            modelBuilder.Entity("projekt.Models.Gry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CenaId")
                        .HasColumnType("int");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Nowy")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RokProdukcji")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("Id");

                    b.HasIndex("CenaId");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Gry");
                });

            modelBuilder.Entity("projekt.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("Id");

                    b.ToTable("Kategoria");
                });

            modelBuilder.Entity("projekt.Models.Producent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Kraj")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("Id");

                    b.ToTable("Producent");
                });

            modelBuilder.Entity("GryProducent", b =>
                {
                    b.HasOne("projekt.Models.Gry", null)
                        .WithMany()
                        .HasForeignKey("GryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projekt.Models.Producent", null)
                        .WithMany()
                        .HasForeignKey("ProducentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projekt.Models.Gry", b =>
                {
                    b.HasOne("projekt.Models.Cena", "Cena")
                        .WithMany("Gry")
                        .HasForeignKey("CenaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projekt.Models.Kategoria", "Kategoria")
                        .WithMany("Gry")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cena");

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("projekt.Models.Cena", b =>
                {
                    b.Navigation("Gry");
                });

            modelBuilder.Entity("projekt.Models.Kategoria", b =>
                {
                    b.Navigation("Gry");
                });
#pragma warning restore 612, 618
        }
    }
}
