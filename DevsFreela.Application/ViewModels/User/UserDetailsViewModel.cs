using DevsFreela.Core.Entities;

namespace DevsFreela.Application.ViewModels.Project
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(int id, string fullName, string email, DateTime birthDate, DateTime createdAt, bool active)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            Active = active;
        }

        public int Id { get; set; }

        public string FullName { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public bool Active { get; private set; }
    }
}
