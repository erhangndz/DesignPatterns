using DesignPattern.Facade.DataAccess;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        

        Order order = new();
        OrderDetail orderDetail = new();
        ProductStock productStock = new();


        AddOrder addOrder = new();
        AddOrderDetail addorderDetail = new();

        public void CompleteOrderDetail(int customerId,int productId,int orderId,int productCount,decimal productPrice)
        {
            

            orderDetail.CustomerId = customerId;
            orderDetail.ProductId= productId;
            orderDetail.OrderId= orderId;
            orderDetail.ProductCount= productCount;
            orderDetail.ProductPrice= productPrice;
            decimal totalProductPrice= productCount * productPrice;
            orderDetail.ProductTotalPrice= totalProductPrice;
            addorderDetail.AddNewOrderDetail(orderDetail);

            productStock.DecreaseStock(productId, productCount);
        }

        public void CompleteOrder(int customerId)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
