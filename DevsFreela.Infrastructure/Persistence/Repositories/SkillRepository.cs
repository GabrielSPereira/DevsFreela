using DevsFreela.Core.DTOs;
using DevsFreela.Core.Entities;
using DevsFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevsFrella.Infrastructure.Persistence.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly DevsFreelaDbContext _dbContext;
        public SkillRepository(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillDTO>> GetAllAsync()
        {
            var skills = _dbContext.Skills;
            var skillsViewModel = await skills.Select(x => new SkillDTO(x.Id, x.Description)).ToListAsync();

            return skillsViewModel;
        }
    }
}
