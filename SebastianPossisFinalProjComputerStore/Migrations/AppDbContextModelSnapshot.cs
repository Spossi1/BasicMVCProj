﻿// <auto-generated />
using ComputerPartsStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SebastianPossisFinalProjComputerStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ComputerPartsStore.Models.ComputerPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ComputerParts");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Description = "High-performance GPU",
                            Name = "Graphics Card",
                            Price = 399.99m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 5,
                            Description = "Quad-core CPU",
                            Name = "Processor",
                            Price = 299.99m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 6,
                            Description = "16GB DDR4",
                            Name = "RAM",
                            Price = 79.99m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 7,
                            Description = "512GB NVMe SSD",
                            Name = "SSD",
                            Price = 119.99m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 8,
                            Description = "ATX Motherboard",
                            Name = "Motherboard",
                            Price = 149.99m,
                            Stock = 12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
