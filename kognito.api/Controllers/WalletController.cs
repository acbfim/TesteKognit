
using AutoMapper;
using kognito.domain;
using kognito.domain.Dtos;
using kognito.service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace kognito.api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService service;
        private readonly IMapper mapper;

        public WalletController(IWalletService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Wallet>> GetAllByUserId([FromQuery] long userId)
        {
            var ret = await this.service.GetAllByUserIdAsync(userId);

            if(ret == null)
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to try add user");

            if(ret.Count == 0)
                return NoContent();

            return Ok(ret);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Add([FromBody] CreateWallet wallet)
        {
            var walletMapped = this.mapper.Map<Wallet>(wallet);
            var ret = await this.service.AddAsync(walletMapped);

            if(ret == null)
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to try add user");

            return Ok(ret);
        }

    }
}