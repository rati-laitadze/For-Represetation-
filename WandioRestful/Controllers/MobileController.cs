using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WandioRestful.Entities;
using WandioRestful.Models;
using WandioRestful.Profiles;
using WandioRestful.ResourceParameters;
using WandioRestful.Services;

namespace WandioRestful.Controllers
{
    [ApiController]
    [Route("api/mobiles")]
    public class MobileController : ControllerBase
    {
        private readonly IMobileRepository mobileRepository;
        private readonly IMapper mapper;


        public MobileController(IMobileRepository mobileRepository, IMapper mapper)
        {
            this.mobileRepository = mobileRepository ??
                throw new ArgumentException(nameof(mobileRepository));
            this.mapper = mapper ??
                throw new ArgumentException(nameof(mapper));
        }
      
        [HttpGet()]
        public ActionResult<IEnumerable<MobileDto>> GetMobile([FromQuery] MobilesResourceParameters mobilesResourceParameters)
        {
            var mobile = mobileRepository.GetMobiles(mobilesResourceParameters);
            if (mobile == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<IEnumerable<MobileDto>>(mobile));
        }

        [HttpGet("Details/{mobileid}")]
        public IActionResult GetDetailsMobile(int mobileId)
        {
            var mobile = mobileRepository.GetMobile(mobileId);
            if (mobile == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<MobileDetailDto>(mobile));
        }
    }
}