using hepiburada.Core.Contents;
using hepiburada.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace hepiburada.Controllers
{
    public class CustomerController (HepsiburadaDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
