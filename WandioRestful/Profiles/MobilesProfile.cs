using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WandioRestful.Profiles
{
    public class MobilesProfile: Profile
    {
        public MobilesProfile()
        {
            CreateMap<Entities.Mobile, Models.MobileDto>();
        }
    }
}
