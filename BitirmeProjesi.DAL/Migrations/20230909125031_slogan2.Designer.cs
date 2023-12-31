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
    [Migration("20230909125031_slogan2")]
    partial class slogan2
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
                            LastLongDate = new DateTime(2023, 9, 9, 15, 50, 31, 706, DateTimeKind.Local).AddTicks(7303),
                            NameSurname = "Arda Oran",
                            Password = "202cb962ac59075b964b07152d234b70",
                            UserName = "arda"
                        });
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

                    b.HasKey("ID");

                    b.ToTable("Category");
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
#pragma warning restore 612, 618
        }
    }
}
