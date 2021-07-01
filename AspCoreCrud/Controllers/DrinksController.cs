using AspCoreCrud.Data;
using AspCoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AspCoreCrud.Controllers
{
    public class DrinksController : Controller
    {
        Data.AppDbContext db;
        public DrinksController(AppDbContext dbcontext)
        {
            db = dbcontext;
        }

        [HttpPost]
        public IActionResult Insert(tblColdDrink drink)
        {
            db.tblColdDrinks.Add(drink);
            db.SaveChanges();
            return Json(new { success = true, message = "Saved Successfully" });
        }
        [HttpGet]
        public IActionResult GetDrinks()
        {
            IEnumerable<tblColdDrink> coldDrinks = db.tblColdDrinks;
            return Json(new { data = coldDrinks });

        }
        [HttpPost]
        public IActionResult Update(tblColdDrink tbl)
        {
            db.tblColdDrinks.Update(tbl);
            db.SaveChanges();
            return Json(new { success = true, message = "Saved Updated" });


        }






        [HttpPost]
        public IActionResult Delete(int id)
        {
            db.tblColdDrinks.Remove(db.tblColdDrinks.Where<tblColdDrink>(m => m.intColdDrinksId == id).FirstOrDefault());
            db.SaveChanges();
            return Json(new { success = true, message = "Deleted Successfully" });
        }


        [HttpPost]
        public IActionResult DeleteAll()
        {
            db.tblColdDrinks.RemoveRange(db.tblColdDrinks.Where<tblColdDrink>(m => m.numQuantity< 500));
            db.SaveChanges();
            return Json(new { success = true, message = "Deleted Successfully" });
        }

        [HttpGet]
        public IActionResult PriceAllProduct()
        {
            IEnumerable<tblColdDrink> coldDrinks = db.tblColdDrinks;
            var total = coldDrinks.Sum(s => (s.numQuantity * s.numUnitPrice));
            return Json(new { data = total });

        }



    }
}
