using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WandioRestful.Entities
{
    public class Mobile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        [Required]
        public double Size { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public string ScreenSizeAndResolution { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public int MemoryInGB { get; set; }
        [Required]
        public OS OperatingSystem { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string ImageThumbnailUrl { get; set; }
    }
}
