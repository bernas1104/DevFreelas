using Microsoft.AspNetCore.Mvc;

namespace DevFreelas.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int query)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] object model)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(
            [FromRoute] int id, 
            [FromBody] object model
        )
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPost("{id}/comments")]
        public async Task<IActionResult> PostComment([FromBody] object model)
        {
            return Ok();
        }

        [HttpPut("{id}/start")]
        public async Task<IActionResult> Start([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut("{id}/finish")]
        public async Task<IActionResult> Finish([FromRoute] int id)
        {
            return Ok();
        }
    }
}