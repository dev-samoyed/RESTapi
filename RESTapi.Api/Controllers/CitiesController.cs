using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTapi.Service.Interfaces;
using RESTapi.Service.Models;

namespace RESTapi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        protected readonly IMapper _mapper;
        private readonly ICityService _cityService;

        public CitiesController(IMapper mapper, ICityService cityService)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        // POST api/cities
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CityModel cityModel)
        {
            try
            {
                if (cityModel == null)
                    return BadRequest();

                var result = await _cityService.AddCityAsync(cityModel);
                return Ok(result);
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
    }
}