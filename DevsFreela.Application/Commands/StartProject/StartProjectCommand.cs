using MediatR;
namespace DevsFreela.Application.Commands.StartProject
{
    public class StartProjectCommand : IRequest<Unit>
    {
        public StartProjectCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
