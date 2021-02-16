using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WandioRestful.Entities;
using WandioRestful.Models;
using WandioRestful.ResourceParameters;
using WandioRestful.Services;

namespace WandioRestful.Controllers
{
    [ApiController]
    [Route("api/manufacturer")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IMobileRepository mobileRepository;
        private readonly IMapper mapper;

        public ManufacturerController(IMobileRepository mobileRepository, IMapper mapper )
        {
            this.mobileRepository = mobileRepository;
            this.mapper = mapper;
        }
        
        [HttpGet()]
        public ActionResult<IEnumerable<Manufacturer>> GetManufacturers()
        {
            return Ok(mobileRepository.GetManufacturers());
        }
    }
}
