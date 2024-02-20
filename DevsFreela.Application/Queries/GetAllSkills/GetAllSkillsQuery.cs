using DevsFreela.Application.ViewModels;
using MediatR;
namespace DevsFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillViewModel>>
    {
    }
}
