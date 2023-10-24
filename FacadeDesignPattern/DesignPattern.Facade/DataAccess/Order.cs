using Microsoft.Identity.Client;

namespace DesignPattern.Facade.DataAccess
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; } 
        public Customer Customer { get; set; } 
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
