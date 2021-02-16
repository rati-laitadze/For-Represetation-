using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WandioRestful.ResourceParameters
{
    public class MobilesResourceParameters
    {
        public int ManufacturerId { get; set; }
        public string SearchQuery { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int Page { get; set; }
    }
}
