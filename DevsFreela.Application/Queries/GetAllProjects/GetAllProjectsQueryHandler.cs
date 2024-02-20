using DevsFreela.Application.ViewModels;
using DevsFreela.Application.ViewModels.Project;
using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, List<ProjectViewModel>>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public GetAllProjectsQueryHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProjectViewModel>> Handle(GetAllProjectsQuery query, CancellationToken cancellationToken)
        {
            var projects = _dbContext.Projects;
            var projectsViewModel = await projects.Select(x => new ProjectViewModel(x.Id, x.Title, x.CreatedAt)).ToListAsync();
            return projectsViewModel;
        }
    }
}
