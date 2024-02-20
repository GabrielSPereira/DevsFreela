using DevsFreela.Application.Commands.UpdateProject;
using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Commands.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public UpdateProjectCommandHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects.SingleOrDefaultAsync(x => x.Id == request.Id);
            project?.Update(request.Title, request.Description, request.TotalCost);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
