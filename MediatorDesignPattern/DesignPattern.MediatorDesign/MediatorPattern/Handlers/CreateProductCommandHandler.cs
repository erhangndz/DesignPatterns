using DesignPattern.MediatorDesign.DataAccess;
using DesignPattern.MediatorDesign.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _context.Products.AddAsync(new Product
            {
                Name = request.Name,
                Category = request.Category,
                Price = request.Price,
                Stock = request.Stock,
                StockType = request.StockType
            });
            await _context.SaveChangesAsync();
        }
    }
}
