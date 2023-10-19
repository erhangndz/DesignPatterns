using DesignPattern.Observer.DataAccess;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            
        }

    

        public void CreateUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                Code = "DERGIMART",
                Amount = 35,
                CodeStatus=true,
            });
            context.SaveChanges();
        }
    }
}
