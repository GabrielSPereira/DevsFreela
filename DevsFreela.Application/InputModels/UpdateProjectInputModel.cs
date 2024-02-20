namespace DevsFreela.Application.InputModels
{
    public class UpdateProjectInputModel
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public decimal TotalCost { get; set; }
    }
}
