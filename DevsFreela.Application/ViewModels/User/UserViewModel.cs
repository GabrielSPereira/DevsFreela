namespace DevsFreela.Application.ViewModels.Project
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullName, DateTime createdAt)
        {
            Id = id;
            FullName = fullName;
            CreatedAt = createdAt;
        }

        public int Id { get; set; }

        public string FullName { get; private set; }

        public DateTime CreatedAt { get; set; }
    }
}
