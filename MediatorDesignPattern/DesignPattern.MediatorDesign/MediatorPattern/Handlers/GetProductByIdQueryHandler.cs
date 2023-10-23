using DesignPattern.MediatorDesign.DataAccess;
using DesignPattern.MediatorDesign.MediatorPattern.Queries;
using DesignPattern.MediatorDesign.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.MediatorDesign.MediatorPattern.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.id);
            return new GetProductByIdQueryResult
            {
                ProductId = values.ProductId,
                Name = values.Name,
                Stock = values.Stock
            };
        }
    }
}
