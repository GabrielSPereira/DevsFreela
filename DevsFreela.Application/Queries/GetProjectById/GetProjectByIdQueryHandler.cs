using DevsFreela.Core.Repositories;
using DevsFrella.Infrastructure.Persistence;
using MediatR;

namespace DevsFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, ViewModels.Project.ProjectDetailsViewModel>
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectByIdQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<ViewModels.Project.ProjectDetailsViewModel?> Handle(GetProjectByIdQuery query, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(query.Id);

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
