using DataAccessLayer.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = request.Id,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
