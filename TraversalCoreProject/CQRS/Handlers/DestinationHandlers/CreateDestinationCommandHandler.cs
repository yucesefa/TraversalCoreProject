using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand createDestinationCommand)
        {
            _context.Destinations.Add(new Destination
            {
                Capacity = createDestinationCommand.Capacity,
                City = createDestinationCommand.City,
                Price = createDestinationCommand.Price,
                DayNight = createDestinationCommand.DayNight,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
