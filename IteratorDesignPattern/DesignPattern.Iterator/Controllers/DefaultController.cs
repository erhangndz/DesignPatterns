using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> routes = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "Almanya",
                City = "Berlin",
                Location = "Berlin Duvarı"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "Fransa",
                City = "Paris",
                Location = "Eyfel Kulesi"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "İtalya",
                City = "Venedik",
                Location = "San Marco Meydanı"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "İtalya",
                City = "Roma",
                Location = "Colleseum"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "Çekya",
                City = "Prag",
                Location = "Old Town Square"
            });

            var iterator= visitRouteMover.CreateIterator();

            while (iterator.NextLocation())
            {
                routes.Add(iterator.CurrentItem.Country + "/ " +  iterator.CurrentItem.City + "/ " + iterator.CurrentItem.Location);
            }

            ViewBag.route = routes;
            return View();
        }
    }
}
