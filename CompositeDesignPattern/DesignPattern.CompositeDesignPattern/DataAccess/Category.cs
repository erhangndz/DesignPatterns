namespace DesignPattern.CompositeDesignPattern.DataAccess
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int UpperCategoryId { get; set; }
        public List<Product> Products { get; set; }
    }
}
