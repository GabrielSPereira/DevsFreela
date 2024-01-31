using DevsFreela.Application.InputModels;
using DevsFreela.Application.Services.Interfaces;
using DevsFreela.Application.ViewModels;
using DevsFreela.Core.Entities;
using DevsFrella.Infrastructure.Persistence;

namespace DevsFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevsFreelaDbContext _dbContext;
        public SkillService(DevsFreelaDbContext dbContext)
        {

            _dbContext = dbContext;
        }
        public List<SkillViewModel> GetAll()
        {
            var skills = _dbContext.Skills;
            var skillsViewModel = skills.Select(x => new SkillViewModel(x.Id, x.Description)).ToList();
            return skillsViewModel;
        }
    }
}
