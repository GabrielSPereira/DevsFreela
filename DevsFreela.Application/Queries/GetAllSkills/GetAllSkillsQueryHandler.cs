using DevsFreela.Application.ViewModels;
using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQueryHandler : IRequestHandler<GetAllSkillsQuery, List<SkillViewModel>>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public GetAllSkillsQueryHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillViewModel>> Handle(GetAllSkillsQuery query, CancellationToken cancellationToken)
        {
            var skills = _dbContext.Skills;
            var skillsViewModel = await skills.Select(x => new SkillViewModel(x.Id, x.Description)).ToListAsync();
            return skillsViewModel;
        }
    }
}
