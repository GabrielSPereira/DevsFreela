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
        ProjectDetailsViewModel GetById(int id);

        void Start(int id);

        void Finish(int id);
    }
}
