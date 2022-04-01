using Microsoft.AspNetCore.Mvc;
using WebAppA.Controllers.Data;
using WebAppA.Models;

namespace WebAppA.Controllers
{
    public class CatagoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CatagoryController(ApplicationDbContext db) { 
            _db = db;
      
        
        
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategorylist = _db.Categories.ToList(); 
            return View(objCategorylist);
        }
        //GET
        public IActionResult Create () {
            
        return View();  
        
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {

            if (obj.Name == obj.DisplayOrder.ToString()) {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
