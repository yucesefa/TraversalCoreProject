using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand updateDestinationCommand)
        {
            var values = _context.Destinations.Find(updateDestinationCommand.DestinationId);
            values.DayNight = updateDestinationCommand.DayNight;
            values.City = updateDestinationCommand.City;
            values.Price=updateDestinationCommand.Price;
            _context.SaveChanges();
        }
    }
}
