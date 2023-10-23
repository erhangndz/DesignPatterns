using DesignPattern.MediatorDesign.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
