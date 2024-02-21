using DevsFreela.Application.Commands.CreateComment;
using DevsFreela.Application.Commands.CreateProject;
using DevsFreela.Application.Commands.DeleteProject;
using DevsFreela.Application.Commands.FinishProject;
using DevsFreela.Application.Commands.StartProject;
using DevsFreela.Application.Commands.UpdateProject;
using DevsFreela.Application.InputModels;
using DevsFreela.Application.Queries.GetAllProjects;
using DevsFreela.Application.Queries.GetProjectById;
using DevsFreela.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DevsFrella.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMediator _mediator;
        public ProjectsController(IProjectService projectService, IMediator mediator) 
        {
            _projectService = projectService;
            _mediator = mediator;
        }


        [HttpGet]
        public IActionResult Get(string query)
        {
            var getAllProjectsQuery = new GetAllProjectsQuery(query);
            var projects = _mediator.Send(getAllProjectsQuery);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var getProjectById = new GetProjectByIdQuery(id);
            var project = _mediator.Send(getProjectById);
            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProjectCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public async Task<IActionResult> PostComment(int id, [FromBody] CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public async Task<IActionResult> Start(int id)
        {
            var command = new StartProjectCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public async Task<IActionResult> Finish(int id)
        {
            var command = new FinishProjectCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        /*[HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] CreateProjectModel createProject)
        {
            return NoContent();
        }*/
    }
}
