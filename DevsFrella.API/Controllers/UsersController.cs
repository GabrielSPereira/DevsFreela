using Microsoft.AspNetCore.Mvc;

namespace DevsFrella.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        /*[HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        [HttpPut("{id}")]
        public IActionResult Post(int id, [FromBody] UpdateProjectModel updateProject)
        {

            return NoContent();
        }*/
    }
}
