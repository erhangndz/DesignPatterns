using DesignPattern.Repository.BusinessLayer.Abstract;
using DesignPattern.Repository.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Repository.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IGenericService<Category> _categoryService;

        public CategoryController(IGenericService<Category> categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
           var value= _categoryService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
