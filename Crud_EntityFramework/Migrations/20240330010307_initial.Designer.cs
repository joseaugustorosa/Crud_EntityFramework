﻿// <auto-generated />
using System;
using Crud_EntityFramework.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crud_EntityFramework.Migrations
{
    [DbContext(typeof(InfnetDbContext))]
    [Migration("20240330010307_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Crud_EntityFramework.Models.Computadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data_compra")
                        .HasColumnType("TEXT");

                    b.Property<string>("HD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Memória")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroPratrimonio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Placa_Mae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Processador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Computadores");
                });
#pragma warning restore 612, 618
        }
    }
}