using DevsFreela.Application.InputModels;
using DevsFreela.Application.Services.Implementations;
using DevsFreela.Application.Services.Interfaces;
using DevsFreela.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevsFrella.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        public UsersController(IUserService userService, IProjectService projectService)
        {
            _userService = userService;
            _projectService = projectService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel inputModel)
        {
            var id = _userService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { id = inputModel.Id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUserInputModel updateProject)
        {
            _userService.Update(updateProject);
            return NoContent();
        }
    }
}
