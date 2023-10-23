using DesignPattern.CompositeDesignPattern.CompositePattern;
using DesignPattern.CompositeDesignPattern.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CompositeDesignPattern.Controllers
{
    
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories= _context.Categories.Include(x=>x.Products).ToList();
            var values = Recursive(categories, new Category { Name = "FirstCategory", CategoryId = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v=values;
            return View();
        }

        public ProductComposite Recursive(List<Category> categories,Category firstCategory,ProductComposite firstComposite,ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.CategoryId).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryId, y.Name);

                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductId, z.Name));
                });

                if (leaf != null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }

                Recursive(categories, y, firstComposite, productComposite);
            });

            return firstComposite;
        }

    }
}
