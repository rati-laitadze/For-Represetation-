using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WandioRestful.Entities;
using WandioRestful.ResourceParameters;

namespace WandioRestful.Services
{
    public interface IMobileRepository
    {
        IEnumerable<Mobile> GetMobilesOnManufacturers(MobilesResourceParameters mobilesResourceParameters);
        IEnumerable<Mobile> GetMobiles(int page);
        public Mobile GetMobile(int mobileId);
        IEnumerable<Mobile> GetMobiles(MobilesResourceParameters mobilesResourceParameters);
        IEnumerable<Manufacturer> GetManufacturers();

    }
}
