using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveDestinationCommand removeDestinationCommand)
        {
            var values = _context.Destinations.Find(removeDestinationCommand.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
