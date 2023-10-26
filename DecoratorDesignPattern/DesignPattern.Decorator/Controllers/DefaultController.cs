using DesignPattern.Decorator.DataAccess;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            
            CreateNewMessage createNewMessage = new();
            createNewMessage.SendMessage(message);
            return View();
        }

       

        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index2(Message message)
        {
            
            CreateNewMessage createNewMessage = new();
            EncryptedBySubjectDecorator encryptedBySubject = new(createNewMessage);
            encryptedBySubject.SendMessagebyEncryptedSubject(message);

            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index3(Message message)
        {
            CreateNewMessage createNewMessage = new();
            SubjectIDDecorator subjectIDDecorator = new(createNewMessage);
            subjectIDDecorator.SendMessageSubjectID(message);
            return View();
        }

       
    }
}
