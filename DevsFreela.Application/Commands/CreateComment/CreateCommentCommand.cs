using MediatR;
namespace DevsFreela.Application.Commands.CreateComment
{
    public class CreateCommentCommand : IRequest<Unit>
    {
        public required string Content { get; set; }

        public int IdProject { get; set; }

        public int IdUser { get; set; }
    }
}
