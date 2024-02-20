using DevsFreela.Application.ViewModels.Project;
using MediatR;
namespace DevsFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQuery : IRequest<List<ProjectViewModel>>
    {
        public GetAllProjectsQuery(string query)
        {
            Query = query;
        }

        public string Query { get; set; }
    }
}
