using Microsoft.AspNetCore.Mvc;
using MVC_APP.Data;
using MVC_APP.Models;

namespace MVC_APP.Controllers
{
    public class CategoryController : Controller

    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
