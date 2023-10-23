using DesignPattern.MediatorDesign.DataAccess;
using DesignPattern.MediatorDesign.MediatorPattern.Queries;
using DesignPattern.MediatorDesign.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.MediatorDesign.MediatorPattern.Handlers
{
    public class UpdateProductByIdQueryHandler : IRequestHandler<UpdateProductByIdQuery, UpdateProductByIdQueryResult>
    {
        private readonly Context _context;

        public UpdateProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(UpdateProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.id);
            return new UpdateProductByIdQueryResult
            {
                ProductId = values.ProductId,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                StockType = values.StockType

            };
        }
    }
}
