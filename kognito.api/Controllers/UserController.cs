using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using kognito.domain;
using kognito.domain.Dtos;
using kognito.service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace kognito.api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        private readonly IMapper mapper;

        public UserController(IUserService service,IMapper mapper)
        {
            this.mapper = mapper;
            this.service = service;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Add([FromBody] CreateUser user)
        {
            var userMapped = this.mapper.Map<User>(user);
            var ret = await this.service.AddAsync(userMapped);

            if(ret == null)
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to try add user");

            return Ok(ret);
        }

    }
}