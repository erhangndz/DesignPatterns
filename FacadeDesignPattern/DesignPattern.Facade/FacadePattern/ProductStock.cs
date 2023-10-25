using DesignPattern.Facade.DataAccess;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context context = new();

        public ProductStock()
        {
            
        }

        public void DecreaseStock(int id,int amount)
        {
            var value = context.Products.Find(id);
            value.Stock-=amount;
            context.SaveChanges();
        }
    }
}
