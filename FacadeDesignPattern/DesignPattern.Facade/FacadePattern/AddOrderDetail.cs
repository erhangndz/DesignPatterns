using DesignPattern.Facade.DataAccess;

namespace DesignPattern.Facade.FacadePattern
{
    public class AddOrderDetail
    {
        Context context = new();

        public AddOrderDetail()
        {
            
        }
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            context.OrderDetail.Add(orderDetail);
            context.SaveChanges();
        }
    }
}
