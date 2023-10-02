using DesignPattern.ChainOfResponsibility.ChainofResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee assistantManager= new AssistantManager();
            Employee manager= new Manager();
            Employee regionalManager= new RegionalManager();

            treasurer.SetNextApprover(assistantManager);
            assistantManager.SetNextApprover(manager);
            manager.SetNextApprover(regionalManager);

            treasurer.ProcessRequest(model);
            return NoContent();
            
        }
    }
}
