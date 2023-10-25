﻿using DesignPattern.Facade.DataAccess;

namespace DesignPattern.Facade.FacadePattern
{
    public class AddOrder
    {
        Context context = new();

        public AddOrder()
        {
            
        }

        public void AddNewOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            context.Orders.Add(order);
            context.SaveChanges();
        }



    }
}
