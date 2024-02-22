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
    }
}
