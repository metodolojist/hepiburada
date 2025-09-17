using hepiburada.Core.Contents;
using hepiburada.Core.Entity;
using hepiburada.ViewModels;
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
            var customers = context.Customers.ToList();

            var createViewModel = new OrderCreateViewModel();
            createViewModel.Customers = customers;

            return View(createViewModel);
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
