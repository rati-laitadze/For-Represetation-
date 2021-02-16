using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WandioRestful.Profiles
{
    public class MobileDetailProfile : Profile
    {
        public MobileDetailProfile()
        {
            CreateMap<Entities.Mobile, Models.MobileDetailDto>()
                .ForMember(dest => dest.OperatingSystem, opt => opt.MapFrom(src =>src.OperatingSystem.ToString()));

        }
    }
}
