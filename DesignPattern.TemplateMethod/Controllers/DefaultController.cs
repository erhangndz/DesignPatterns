using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.planType = netflixPlans.PlanType("Temel Plan");
            ViewBag.personCount = netflixPlans.CountPerson(1);
            ViewBag.price = netflixPlans.Price(65.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi");
            ViewBag.resolution = netflixPlans.Resolution("480p");
            
            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans= new StandardPlan();
            ViewBag.planType = netflixPlans.PlanType("Standart Plan");
            ViewBag.personCount = netflixPlans.CountPerson(2);
            ViewBag.price = netflixPlans.Price(75.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Belgesel");
            ViewBag.resolution = netflixPlans.Resolution("720p");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans= new UltraPlan();
            ViewBag.planType = netflixPlans.PlanType("Ultra Plan");
            ViewBag.personCount = netflixPlans.CountPerson(4);
            ViewBag.price = netflixPlans.Price(95.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Belgesel-Animasyon");
            ViewBag.resolution = netflixPlans.Resolution("1080p");
            return View();
        }
    }
}
