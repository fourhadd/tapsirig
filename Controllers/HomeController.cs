using Microsoft.AspNetCore.Mvc;
using tapsirig.Models;
using System.Linq;

namespace tapsirig.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Products.ToList();
            return View(items);
        }

        [HttpPost]
        public IActionResult Add(string name, int count)
        {
            if (string.IsNullOrEmpty(name) || count <= 0) return RedirectToAction("Index");

            var item = _context.Products.FirstOrDefault(i => i.Name.ToLower() == name.ToLower());
            if (item == null)
            {
                _context.Products.Add(new Product { Name = name, Count = count });
            }
            else
            {
                item.Count += count;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
public IActionResult Delete(int id)
{
    var item = _context.Products.Find(id);
    if (item != null)
    {
        _context.Products.Remove(item);
        _context.SaveChanges();
        TempData["StockWarning"] = "Məhsul siyahıdan silindi.";
    }
    return RedirectToAction("Index");
}

[HttpPost]
public IActionResult Sell(int id)
{
    var item = _context.Products.Find(id);
    if (item != null)
    {
        if (item.Count > 0)
        {
            item.Count--;
            _context.SaveChanges();
            
            // Satışdan sonra say 0 oldusa, mesaj göndər
            if (item.Count == 0)
            {
                TempData["StockWarning"] = $"{item.Name} artıq tukendi!";
            }
        }
        else
        {
            // Əgər kimsə hansısa yolla 0 olan məhsulu satmağa çalışsa
            TempData["StockWarning"] = "Bu mehsul artıq bitib!";
        }
    }
    return RedirectToAction("Index");
}
    }
}