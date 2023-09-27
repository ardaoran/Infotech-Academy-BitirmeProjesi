﻿// <auto-generated />
using System;
using BitirmeProjesi.DAL.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BitirmeProjesi.DAL.Migrations
{
    [DbContext(typeof(SQLContext))]
    [Migration("20230910183250_BrandCategoryDiagram")]
    partial class BrandCategoryDiagram
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("LastLoginIP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("LastLongDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("Varchar(32)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            LastLoginIP = "",
                            LastLongDate = new DateTime(2023, 9, 10, 21, 32, 50, 232, DateTimeKind.Local).AddTicks(5505),
                            NameSurname = "Arda Oran",
                            Password = "202cb962ac59075b964b07152d234b70",
                            UserName = "arda"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Beygir")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Modeli")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Motor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Seri")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("StokMiktari")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Vites")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.ProductPicture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductPicture");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Slide", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(150)
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Picture")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Slogan1")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Slogan2")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Slide");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Category", b =>
                {
                    b.HasOne("BitirmeProjesi.DAL.Entities.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentID");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Product", b =>
                {
                    b.HasOne("BitirmeProjesi.DAL.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BitirmeProjesi.DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.ProductPicture", b =>
                {
                    b.HasOne("BitirmeProjesi.DAL.Entities.Product", "Product")
                        .WithMany("ProductPictures")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("BitirmeProjesi.DAL.Entities.Product", b =>
                {
                    b.Navigation("ProductPictures");
                });
#pragma warning restore 612, 618
        }
    }
}
