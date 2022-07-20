using DevFreelas.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreelas.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<IActionResult> Get([FromQuery] int query)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> Post([FromBody] NewProjectInputModel model)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetById([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public Task<IActionResult> Put(
            [FromRoute] int id,
            [FromBody] UpdateProjectInputModel model
        )
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> Delete([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/comments")]
        public Task<IActionResult> PostComment(
            [FromBody] CreateCommentInputModel model
        )
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}/start")]
        public Task<IActionResult> Start([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}/finish")]
        public Task<IActionResult> Finish([FromRoute] int id)
        {
            throw new NotImplementedException();
        }
    }
}
