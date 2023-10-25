using DesignPattern.Facade.DataAccess;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new();
        
      


        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult AddOrderDetail()
        {
            List<SelectListItem> customers = (from x in context.Customers.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.NameSurname,
                                                  Value = x.CustomerId.ToString()
                                              }).ToList();
            ViewBag.customer = customers;
            List<SelectListItem> products = (from x in context.Products.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.ProductName,
                                                 Value = x.ProductId.ToString()
                                             }).ToList();
            ViewBag.product = products;

            List<SelectListItem> orders = (from x in context.Orders.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.OrderId.ToString(),
                                                 Value = x.OrderId.ToString()
                                             }).ToList();
            ViewBag.order = orders;
            return View();
        }

        [HttpPost]
        public IActionResult AddOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            OrderFacade order = new();
            order.CompleteOrderDetail(customerId, productId, orderId, productCount, productPrice);
            return RedirectToAction("Index");
        }

        public IActionResult AddOrder()
        {
            List<SelectListItem> customers = (from x in context.Customers.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.NameSurname,
                                                  Value = x.CustomerId.ToString()
                                              }).ToList();
            ViewBag.customer = customers;
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(int CustomerId)
        {
            OrderFacade order = new();
            order.CompleteOrder(CustomerId);
            return RedirectToAction("Index");
        }
    }
}
