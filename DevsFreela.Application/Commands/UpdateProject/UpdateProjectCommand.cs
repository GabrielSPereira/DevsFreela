using MediatR;
namespace DevsFreela.Application.Commands.UpdateProject
{
    public class UpdateProjectCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public decimal TotalCost { get; set; }
    }
}
