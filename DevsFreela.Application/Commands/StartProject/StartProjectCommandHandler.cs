using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Commands.StartProject
{
    public class StartProjectCommandHandler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public StartProjectCommandHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects.SingleOrDefaultAsync(x => x.Id == request.Id);
            project?.Start();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
