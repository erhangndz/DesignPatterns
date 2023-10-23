using DesignPattern.MediatorDesign.DataAccess;
using DesignPattern.MediatorDesign.MediatorPattern.Queries;
using DesignPattern.MediatorDesign.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.MediatorDesign.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
                StockType = x.StockType,
                Category= x.Category,

            }).AsNoTracking().ToListAsync();
        }
    }
}
