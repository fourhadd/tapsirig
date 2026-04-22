using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class InventoryItem
{
    public string? Name { get; set; }
    public int Count { get; set; }
}

public class HomeController : Controller
{
    // Nümunə üçün static siyahı
    private static List<InventoryItem> Items = new List<InventoryItem>
    {
        new InventoryItem { Name = "Düyü", Count = 2 }
    };

    public IActionResult Index()
    {
        return View(Items);
    }

    [HttpPost]
    public IActionResult Add(int count)
    {
        var item = Items.FirstOrDefault(i => i.Name == "Düyü");
        if (item != null) item.Count += count;
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Sell()
    {
        var item = Items.FirstOrDefault(i => i.Name == "Düyü");
        if (item != null && item.Count > 0) item.Count--;
        return RedirectToAction("Index");
    }
}