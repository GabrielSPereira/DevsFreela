using DevsFreela.Application.InputModels;
using DevsFreela.Application.ViewModels;
using DevsFreela.Application.ViewModels.Project;

namespace DevsFreela.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}
