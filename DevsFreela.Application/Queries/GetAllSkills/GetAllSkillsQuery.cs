using DevsFreela.Core.DTOs;
using MediatR;
namespace DevsFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillDTO>>
    {
    }
}
