using Microsoft.AspNetCore.Mvc;

namespace DevFreelas.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] object model)
        {
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] object model)
        {
            return Ok();
        }
    }
}