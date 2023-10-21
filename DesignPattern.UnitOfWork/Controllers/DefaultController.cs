using DesignPattern.UnitOfWork.BusinessLayer.Abstract;
using DesignPattern.UnitOfWork.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IGenericService<Customer> _customerService;

        public DefaultController(IGenericService<Customer> customerService)
        {
            _customerService = customerService;
        }

        
        public IActionResult Index()
        {
            var customerList = _customerService.TGetList();

            List<SelectListItem> customers = (from x in customerList
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.CustomerId.ToString()

                                              }).ToList();
            ViewBag.customers = customers;

            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {

            var customerList = _customerService.TGetList();

            List<SelectListItem> customers = (from x in customerList
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.CustomerId.ToString()

                                              }).ToList();
            ViewBag.customers = customers;

            var senderId = _customerService.TGetById(model.SenderId);
            var receiverId = _customerService.TGetById(model.ReceiverId);

            senderId.Balance -= model.Amount;
            receiverId.Balance += model.Amount;
            List<Customer> modifiedCustomers = new List<Customer>()
            {
                senderId, receiverId
            };
            _customerService.TMultiUpdate(modifiedCustomers); 
            return NoContent();
        }
    }
}
