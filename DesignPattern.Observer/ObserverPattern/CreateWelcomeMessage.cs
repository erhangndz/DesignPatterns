using DesignPattern.Observer.DataAccess;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
           
        }

      

        public void CreateUser(AppUser appUser)
        {
            
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.NameSurname,
                Content = "Dergi bültenimize kayıt olduğunuz için çok teşekkür ederiz. Dergilerimize web sitemizden ulaşabilirsiniz."
            });
            context.SaveChanges();
        }
    }
}
