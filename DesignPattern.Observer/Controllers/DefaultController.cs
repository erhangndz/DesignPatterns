using DesignPattern.Observer.DataAccess;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;


        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var user = new AppUser()
            {
                NameSurname = model.NameSurname,
                Email = model.Email,
                UserName = model.Username
            };

          var result=   await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                _observerObject.NotifyObserver(user);
                return View();
            }
            return View();
        }
    }
}
