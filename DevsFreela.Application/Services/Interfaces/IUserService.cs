using DevsFreela.Application.InputModels;
using DevsFreela.Application.ViewModels.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserDetailsViewModel GetById(int id);

        int Create(NewUserInputModel inputModel);

        void Update(UpdateUserInputModel inputModel);
    }
}
