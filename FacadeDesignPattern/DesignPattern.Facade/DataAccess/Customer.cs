namespace DesignPattern.Facade.DataAccess
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string NameSurname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
