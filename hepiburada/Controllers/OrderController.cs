using hepiburada.Core.Contents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hepiburada.Controllers
{
    public class OrderController (HepsiburadaDbContext context) : Controller 
    {
        public IActionResult Index()


        {
            var orders =context.Orders.Include(x=>x.Customer).ToList();

            return View(orders);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
