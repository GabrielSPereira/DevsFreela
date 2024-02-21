using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, ViewModels.Project.ProjectDetailsViewModel>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public GetProjectByIdQueryHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ViewModels.Project.ProjectDetailsViewModel?> Handle(GetProjectByIdQuery query, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects
                .Include(x => x.Client)
                .Include(x => x.Freelancer)
                .SingleOrDefaultAsync(x => x.Id == query.Id);
            if (project != null)
            {
                var projectViewModel = new ViewModels.Project.ProjectDetailsViewModel(
                    project.Id,
                    project.Title,
                    project.Description,
                    project.TotalCost,
                    project.StartedAt,
                    project.FinishedAt,
                    project.Client.FullName,
                    project.Freelancer.FullName
                );

                return projectViewModel;
            }

            return null;
        }
    }
}
