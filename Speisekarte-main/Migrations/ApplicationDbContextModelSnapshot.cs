﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Speisekarte.Data;

#nullable disable

namespace Speisekarte.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("Speisekarte.Models.Speise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notizen")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Sterne")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Speisen");
                });

            modelBuilder.Entity("Speisekarte.Models.Zutat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Einheit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Menge")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SpeiseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SpeiseId");

                    b.ToTable("Zutaten");
                });

            modelBuilder.Entity("Speisekarte.Models.Zutat", b =>
                {
                    b.HasOne("Speisekarte.Models.Speise", "Speise")
                        .WithMany("Zutaten")
                        .HasForeignKey("SpeiseId");

                    b.Navigation("Speise");
                });

            modelBuilder.Entity("Speisekarte.Models.Speise", b =>
                {
                    b.Navigation("Zutaten");
                });
#pragma warning restore 612, 618
        }
    }
}
