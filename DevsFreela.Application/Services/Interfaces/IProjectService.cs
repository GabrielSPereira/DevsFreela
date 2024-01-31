using DevsFreela.Application.InputModels;
using DevsFreela.Application.ViewModels.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);

        ProjectDetailsViewModel GetById(int id);

        int Create(NewProjectInputModel inputModel);

        void Update(UpdateProjectInputModel inputModel);

        void Delete(int id);

        void CreateComment(CreateCommentInputModel inputModel);

        void Start(int id);

        void Finish(int id);
    }
}
