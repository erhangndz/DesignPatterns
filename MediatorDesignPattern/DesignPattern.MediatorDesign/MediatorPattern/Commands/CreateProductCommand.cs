using MediatR;

namespace DesignPattern.MediatorDesign.MediatorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string StockType { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
