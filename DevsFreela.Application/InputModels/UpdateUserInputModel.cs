namespace DevsFreela.Application.InputModels
{
    public class UpdateUserInputModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }
    }
}
