using DevsFrella.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevsFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommandHandler : IRequestHandler<FinishProjectCommand, Unit>
    {
        private readonly DevsFreelaDbContext _dbContext;

        public FinishProjectCommandHandler(DevsFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects.SingleOrDefaultAsync(x => x.Id == request.Id);
            project?.Finish();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
