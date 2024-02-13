using DevsFreela.Application.InputModels;
using DevsFreela.Application.Services.Interfaces;
using DevsFreela.Application.ViewModels.Project;
using DevsFreela.Core.Entities;
using DevsFrella.Infrastructure.Persistence;

namespace DevsFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevsFreelaDbContext _dbContext;
        public UserService(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.BirthDate);
            _dbContext.Users.Add(user);

            _dbContext.SaveChanges();

            return user.Id;
        }

        public UserDetailsViewModel? GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == id);
            if (user != null)
            {
                var userViewModel = new UserDetailsViewModel(
                    user.Id,
                    user.FullName,
                    user.Email,
                    user.BirthDate,
                    user.CreatedAt,
                    user.Active
                );

                return userViewModel;
            }

            return null;
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == inputModel.Id);
            user?.Update(inputModel.FullName, inputModel.Email, inputModel.BirthDate, inputModel.Active);

            _dbContext.SaveChanges();
        }
    }
}
