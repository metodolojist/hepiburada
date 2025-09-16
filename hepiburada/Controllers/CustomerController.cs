using hepiburada.Core.Contents;
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
    }
}
