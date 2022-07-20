using Microsoft.AspNetCore.Mvc;

namespace DevFreelas.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class SkillsController : ControllerBase
    {
        //

        public SkillsController()
        {
            //
        }

        [HttpGet]
        public Task<IActionResult> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
