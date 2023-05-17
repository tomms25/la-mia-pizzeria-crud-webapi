﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using la_mia_pizzeria_crud_mvc.Models;
using System.Reflection.Emit;

#nullable disable

namespace la_mia_pizzeria_crud_mvc.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20230413135147_CreateTables")]
    partial class CreateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Category", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));
                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("nvarchar(25)");
                b.HasKey("Id");
                b.ToTable("Categories");
            });

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Pizza", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));
                b.Property<long?>("CategoryId")
                    .HasColumnType("bigint");
                b.Property<string>("Description")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");
                b.Property<string>("Img")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("nvarchar(25)");
                b.Property<double>("Price")
                    .HasColumnType("float");
                b.HasKey("Id");
                b.HasIndex("CategoryId");
                b.ToTable("Pizzas");
            });

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Pizza", b =>
            {
                b.HasOne("la_mia_pizzeria_crud_mvc.Models.Category", "Category")
                    .WithMany("Pizzas")
                    .HasForeignKey("CategoryId");
                b.Navigation("Category");
            });

            modelBuilder.Entity("la_mia_pizzeria_crud_mvc.Models.Category", b =>
            {
                b.Navigation("Pizzas");
            });
#pragma warning restore 612, 618
        }
    }
}