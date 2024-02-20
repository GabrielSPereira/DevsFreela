namespace DevsFreela.Application.InputModels
{
    public class NewUserInputModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
