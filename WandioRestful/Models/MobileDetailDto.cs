using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WandioRestful.Entities;

namespace WandioRestful.Models
{

    public class MobileDetailDto
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public double Size { get; set; }
        public double Weight { get; set; }
        public string ScreenSizeAndResolution { get; set; }
        public string Processor { get; set; }
        public int MemoryInGB { get; set; }
        public string OperatingSystem { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}

