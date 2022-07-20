using DevFreelas.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreelas.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Task<IActionResult> Post([FromBody] CreateUserInputModel model)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetById([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("authenticate")]
        public Task<IActionResult> Authenticate([FromBody] object model)
        {
            throw new NotImplementedException();
        }
    }
}
