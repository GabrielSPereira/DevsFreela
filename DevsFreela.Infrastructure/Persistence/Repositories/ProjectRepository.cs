using Azure.Core;
using DevsFreela.Core.Entities;
using DevsFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevsFrella.Infrastructure.Persistence.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DevsFreelaDbContext _dbContext;
        public ProjectRepository(DevsFreelaDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            return await _dbContext.Projects.ToListAsync();
        }

        public async Task<Project?> GetByIdAsync(int id) => await _dbContext.Projects
                .Include(x => x.Client)
                .Include(x => x.Freelancer)
                .SingleOrDefaultAsync(x => x.Id == id);

        public async Task AddAsync(Project project)
        {
            await _dbContext.Projects.AddAsync(project);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
