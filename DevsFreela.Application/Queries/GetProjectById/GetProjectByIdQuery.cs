using DevsFreela.Application.ViewModels.Project;
using MediatR;
namespace DevsFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQuery : IRequest<ProjectDetailsViewModel>
    {
        public GetProjectByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
