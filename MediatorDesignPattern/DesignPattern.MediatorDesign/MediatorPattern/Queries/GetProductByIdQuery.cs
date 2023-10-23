using DesignPattern.MediatorDesign.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdQueryResult>
    {
        public int id { get; set; }

        public GetProductByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
