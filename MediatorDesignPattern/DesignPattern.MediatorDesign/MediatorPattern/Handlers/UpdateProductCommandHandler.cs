

using DesignPattern.MediatorDesign.DataAccess;
using DesignPattern.MediatorDesign.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ProductId);
            values.Name = request.Name;
            values.Stock = request.Stock;
            values.Price = request.Price;
            values.Category = request.Category;
            values.StockType = request.StockType;
            await _context.SaveChangesAsync();
        }
    }
}
