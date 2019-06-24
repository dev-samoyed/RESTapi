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
    public class SubscribersController : ControllerBase
    {
        protected readonly IMapper _mapper;
        private readonly ISubscriberService _subscriberService;

        public SubscribersController(IMapper mapper, ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
            _mapper = mapper;
        }

        // GET api/subscribers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubscriberShowModel>> Get(int id)
        {
            try
            {
                if (!int.TryParse(id.ToString(), out var subscriberId))
                    return BadRequest();

                var subscriber = await _subscriberService.GetSubscriberByIdAsync(subscriberId);
                return Ok(subscriber);
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

        // POST api/subscribers
        [HttpPost]
        public async Task<ActionResult<int>> Add([FromBody] SubscriberModel subscriberModel)
        {
            try
            {
                if (subscriberModel == null)
                    return BadRequest();

                var result = await _subscriberService.AddSubscriberAsync(subscriberModel);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

        // PUT api/subscribers/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Edit(int id, [FromBody] SubscriberModel subscriberModel)
        {
            try
            {
                if (id != subscriberModel.Id)
                    return BadRequest();

                var result = await _subscriberService.EditSubscriberAsync(subscriberModel);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }
    }
}