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
    public class AreasController : ControllerBase
    {
        protected readonly IMapper _mapper;
        private readonly IAreaService _areaService;

        public AreasController(IMapper mapper, IAreaService areaService)
        {
            _areaService = areaService;
            _mapper = mapper;
        }

        // POST api/areas
        [HttpPost]
        public async Task<ActionResult<int>> Add(AreaModel areaModel)
        {
            try
            {
                if(areaModel == null)
                    return BadRequest();

                var result = await _areaService.AddAreaAsync(areaModel);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }
    }
}