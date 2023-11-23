﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp1.Data;

#nullable disable

namespace WebApp1.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231123033529_AddSeeding")]
    partial class AddSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp1.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "SOS",
                            DisplayOrder = 2,
                            Name = "Funny"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hili",
                            DisplayOrder = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cost",
                            DisplayOrder = 1,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Hoel",
                            DisplayOrder = 4,
                            Name = "Lmao"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}