using DesignPattern.MediatorDesign.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Queries
{
    public class UpdateProductByIdQuery:IRequest<UpdateProductByIdQueryResult>
    {
        public UpdateProductByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
