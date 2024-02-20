using DevsFreela.Application.Commands.DeleteProject;
using DevsFrella.Infrastructure.Persistence;
using MediatR;

namespace DevsFreela.Application.Commands.UpdateProject
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public DeleteProjectCommandHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(x => x.Id == request.Id);
            project?.Cancel();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
