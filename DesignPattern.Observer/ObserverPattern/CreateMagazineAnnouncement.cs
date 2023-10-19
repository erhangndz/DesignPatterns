using DesignPattern.Observer.DataAccess;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            
        }

       

        public void CreateUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.NameSurname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim dergimizin mart sayısı 1 Martta evinize ulaştırılacaktır, konular Jupiter ve Mars gezegenleri olacaktır."
            });
            context.SaveChanges();
        }
    }
}
