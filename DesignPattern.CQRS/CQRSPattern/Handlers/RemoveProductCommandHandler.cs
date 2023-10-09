using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DataAccess;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = _context.Products.Find(command.Id);
            _context.Remove(values);
            _context.SaveChanges();
        }
    }
}
