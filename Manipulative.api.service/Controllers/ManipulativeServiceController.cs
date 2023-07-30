using Manipulative.api.service.Core.Entities;
using Manipulative.api.service.Reporsitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manipulative.api.service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManipulativeServiceController : ControllerBase
    {
        private readonly IManipulativeRepository _manipulativeRepository;

        public ManipulativeServiceController(IManipulativeRepository manipulativeRepository)
        {
            _manipulativeRepository = manipulativeRepository;
        }

        [HttpGet("manipulative")]
        public async Task<ActionResult<IEnumerable<manipulative>>> GetManipulative()
        {
            var manipulative = await _manipulativeRepository.GetManipulative();
            return Ok(manipulative);
        }
    }
}
