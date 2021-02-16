using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WandioRestful.Entities
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Mobile> Mobiles { get; set; }
            = new List<Mobile>();
    }
}
