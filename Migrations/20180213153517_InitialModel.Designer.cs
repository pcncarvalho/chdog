﻿// <auto-generated />
using chdog.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace chdog.Migrations
{
    [DbContext(typeof(CHDogDbContext))]
    [Migration("20180213153517_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("chdog.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdRaca");

                    b.Property<int>("Idade");

                    b.Property<string>("Porte");

                    b.Property<int?>("RacaId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("RacaId");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("chdog.Models.Raca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Racas");
                });

            modelBuilder.Entity("chdog.Models.Animal", b =>
                {
                    b.HasOne("chdog.Models.Raca", "Raca")
                        .WithMany()
                        .HasForeignKey("RacaId");
                });
#pragma warning restore 612, 618
        }
    }
}
