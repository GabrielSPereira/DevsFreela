using DevsFrella.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevsFrella.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        [HttpPut("{id}")]
        public IActionResult Post(int id, [FromBody] UpdateProjectModel updateProject)
        {

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateProjectModel createProject)
        {

            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {

            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {

            return NoContent();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] CreateProjectModel createProject)
        {

            return NoContent();
        }
    }
}
