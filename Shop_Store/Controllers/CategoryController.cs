using Microsoft.AspNetCore.Mvc;
using Shop_Store.Data;
using Shop_Store.Models;

namespace Shop_Store.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db; // the database

        /* To do:
         * 
         1.Retrive categories

         */

        public CategoryController(ApplicationDbContext database)
        {
            _db = database;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.OrderByDescending(e => e.Name).ToList();

            return View(objCategoryList);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
