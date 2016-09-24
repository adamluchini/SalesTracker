using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSalesTracker.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSalesTracker.Controllers
{
    public class InventoryController : Controller
    {
        // GET: /<controller>/
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowList()
        {
            var List = db.Inventories.ToList();
            return Json(List);
        }
        [HttpPost]
        public IActionResult NewInventory(string newItem, int newCost, int newSalePrice)
        {
            Inventory newInventory = new Inventory(newItem, newCost, newSalePrice);
            db.Inventories.Add(newInventory);
            db.SaveChanges();
            return Json(newInventory);
        }
    }
}
