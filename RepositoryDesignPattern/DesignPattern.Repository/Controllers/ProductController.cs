using DesignPattern.Repository.BusinessLayer.Abstract;
using DesignPattern.Repository.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPattern.Repository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IGenericService<Category> _categoryService;

        public ProductController(IProductService productService, IGenericService<Category> categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _productService.GetAll();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddProduct()
        {
            var categoryList = _categoryService.TGetList();
            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.category=categories;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(int id)
        {
            var categoryList = _categoryService.TGetList();
            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.category = categories;
            var value = _productService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}
