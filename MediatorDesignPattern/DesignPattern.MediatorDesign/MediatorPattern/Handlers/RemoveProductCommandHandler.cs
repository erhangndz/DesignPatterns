using DesignPattern.MediatorDesign.DataAccess;
using DesignPattern.MediatorDesign.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.MediatorDesign.MediatorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
