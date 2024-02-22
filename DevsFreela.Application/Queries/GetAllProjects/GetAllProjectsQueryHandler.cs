using DevsFreela.Application.ViewModels;
using DevsFreela.Application.ViewModels.Project;
using DevsFreela.Core.Repositories;
using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<ProjectViewModel>>
    {
        private readonly IProjectRepository _projectRepository;

        public GetAllProjectsQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<ProjectViewModel>> Handle(GetAllProjectsQuery query, CancellationToken cancellationToken)
        {
            var projects = await _projectRepository.GetAllAsync();
            var projectsViewModel = projects.Select(x => new ProjectViewModel(x.Id, x.Title, x.CreatedAt)).ToList();
            return projectsViewModel;
        }
    }
}
