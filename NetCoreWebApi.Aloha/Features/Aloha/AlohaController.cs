using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi.Aloha.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.Features.Aloha
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlohaController : ControllerBase
    {
        private readonly AlohaAppService _AlohaAppService;

        public AlohaController(AlohaAppService alohaAppService)
        {
            _AlohaAppService = alohaAppService;
        }

        [HttpGet]
        [Route("get-all-group-members")]
        public async Task<IActionResult> getGroupMember() 
        {
            Response response = await _AlohaAppService.GetAllGroupMembers();

            return Ok(response);
        }
    }
}
