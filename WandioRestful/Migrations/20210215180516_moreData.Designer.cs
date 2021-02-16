﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WandioRestful.DbContexts;

namespace WandioRestful.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210215180516_moreData")]
    partial class moreData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WandioRestful.Entities.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Huawei"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Oppo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "LG"
                        });
                });

            modelBuilder.Entity("WandioRestful.Entities.Mobile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int>("MemoryInGB")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSizeAndResolution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Mobiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 2,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        },
                        new
                        {
                            Id = 2,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 1,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        },
                        new
                        {
                            Id = 3,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 2,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        },
                        new
                        {
                            Id = 4,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 3,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        },
                        new
                        {
                            Id = 5,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 2,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        },
                        new
                        {
                            Id = 6,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 3,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        },
                        new
                        {
                            Id = 7,
                            ImageThumbnailUrl = "davamateb mere",
                            ImageUrl = "davmateb mere",
                            ManufacturerId = 3,
                            MemoryInGB = 16,
                            Name = "Iphone 5",
                            OperatingSystem = "iOS",
                            Price = 350,
                            Processor = "1.3GHz dual-core",
                            ScreenSizeAndResolution = "1136 x 640",
                            Size = 1440.0,
                            Weight = 112.0
                        });
                });

            modelBuilder.Entity("WandioRestful.Entities.Mobile", b =>
                {
                    b.HasOne("WandioRestful.Entities.Manufacturer", "Manufacturer")
                        .WithMany("Mobiles")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("WandioRestful.Entities.Manufacturer", b =>
                {
                    b.Navigation("Mobiles");
                });
#pragma warning restore 612, 618
        }
    }
}
