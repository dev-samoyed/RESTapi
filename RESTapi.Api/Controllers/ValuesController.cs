using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RESTapi.Service.Interfaces;

namespace RESTapi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IContractService _contractService;

        public ValuesController(IMapper mapper, IContractService contractService)
        {
            _mapper = mapper;
            _contractService = contractService;
        }
        // GET api/values/5
        [HttpGet("{dateTime}")]
        [Produces("application/xml")]
        public async Task<ActionResult> Get(DateTime dateTime)
        {
            if (dateTime == null)
                return BadRequest();
            var batch = await _contractService.GetBatchAsync(dateTime);
            if (batch == null)
                return NoContent();
            return Ok(batch);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
