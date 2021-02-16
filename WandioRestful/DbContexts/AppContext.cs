using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WandioRestful.Entities;

namespace WandioRestful.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Mobile>()
                .Property(e => e.OperatingSystem)
                .HasConversion(
                    v => v.ToString(),
                    v => (OS)Enum.Parse(typeof(OS), v));
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer() { Id = 1, Name = "Samsung" },
                new Manufacturer() { Id = 2, Name = "Apple" },
                new Manufacturer() { Id = 3, Name = "Huawei" },
                new Manufacturer() { Id = 4, Name = "Oppo" },
                new Manufacturer() { Id = 5, Name = "LG" }
                );
            modelBuilder.Entity<Mobile>().HasData(
                new Mobile()
                {
                    Id = 1,
                    Name = "Iphone 5",
                    ManufacturerId = 2,
                    MemoryInGB = 16,
                    OperatingSystem = OS.iOS,
                    Price = 350,
                    Processor = "1.3GHz dual-core",
                    ScreenSizeAndResolution = "1136 x 640",
                    Size = 1440,
                    Weight = 112,
                    ImageUrl = "davmateb mere",
                    ImageThumbnailUrl = "davamateb mere"
                },
                new Mobile()
                {
                    Id = 2,
                    Name = "Iphone 5",
                    ManufacturerId = 1,
                    MemoryInGB = 16,
                    OperatingSystem = OS.iOS,
                    Price = 350,
                    Processor = "1.3GHz dual-core",
                    ScreenSizeAndResolution = "1136 x 640",
                    Size = 1440,
                    Weight = 112,
                    ImageUrl = "davmateb mere",
                    ImageThumbnailUrl = "davamateb mere"
                },
                new Mobile()
                {
                    Id = 3,
                    Name = "Iphone 5",
                    ManufacturerId = 2,
                    MemoryInGB = 16,
                    OperatingSystem = OS.iOS,
                    Price = 350,
                    Processor = "1.3GHz dual-core",
                    ScreenSizeAndResolution = "1136 x 640",
                    Size = 1440,
                    Weight = 112,
                    ImageUrl = "davmateb mere",
                    ImageThumbnailUrl = "davamateb mere"
                },
                new Mobile()
                {
                    Id = 4,
                    Name = "Iphone 5",
                    ManufacturerId = 3,
                    MemoryInGB = 16,
                    OperatingSystem = OS.iOS,
                    Price = 350,
                    Processor = "1.3GHz dual-core",
                    ScreenSizeAndResolution = "1136 x 640",
                    Size = 1440,
                    Weight = 112,
                    ImageUrl = "davmateb mere",
                    ImageThumbnailUrl = "davamateb mere"
                },
                new Mobile()
                {
                    Id = 5,
                    Name = "Iphone 5",
                    ManufacturerId = 2,
                    MemoryInGB = 16,
                    OperatingSystem = OS.iOS,
                    Price = 350,
                    Processor = "1.3GHz dual-core",
                    ScreenSizeAndResolution = "1136 x 640",
                    Size = 1440,
                    Weight = 112,
                    ImageUrl = "davmateb mere",
                    ImageThumbnailUrl = "davamateb mere"
                },
                  new Mobile()
                  {
                      Id = 6,
                      Name = "Iphone 5",
                      ManufacturerId = 3,
                      MemoryInGB = 16,
                      OperatingSystem = OS.iOS,
                      Price = 350,
                      Processor = "1.3GHz dual-core",
                      ScreenSizeAndResolution = "1136 x 640",
                      Size = 1440,
                      Weight = 112,
                      ImageUrl = "davmateb mere",
                      ImageThumbnailUrl = "davamateb mere"
                  },
                    new Mobile()
                    {
                        Id = 7,
                        Name = "Iphone 5",
                        ManufacturerId = 3,
                        MemoryInGB = 16,
                        OperatingSystem = OS.iOS,
                        Price = 350,
                        Processor = "1.3GHz dual-core",
                        ScreenSizeAndResolution = "1136 x 640",
                        Size = 1440,
                        Weight = 112,
                        ImageUrl = "davmateb mere",
                        ImageThumbnailUrl = "davamateb mere"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
