using DevsFreela.Application.Services.Interfaces;
using DevsFreela.Application.ViewModels.Project;
using DevsFrella.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevsFreelaDbContext _dbContext;
        public ProjectService(DevsFreelaDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public void Finish(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Finish();

            _dbContext.SaveChanges();
        }

        public ProjectDetailsViewModel? GetById(int id)
        {
            var project = _dbContext.Projects
                .Include(x => x.Client)
                .Include(x => x.Freelancer)
                .SingleOrDefault(x => x.Id == id);
            if (project != null)
            {
                var projectViewModel = new ProjectDetailsViewModel(
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

        public void Start(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == id);
            project?.Start();

            _dbContext.SaveChanges();
        }
    }
}
