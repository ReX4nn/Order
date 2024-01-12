using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {

        private ApplicationContext db;
        public OrderController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<OrderViewModel> orders = db.Orders.ToList();
            return View(orders);
        }

        public IActionResult OrderDetails(int id)
        {
            var order = db.Orders.FirstOrDefault(x => x.Id == id);
            if(order == null)
            {
                return Redirect("Index");
            }

            return View(order);
        }

        public IActionResult Create()
        {
            
            var orderVm = new OrderViewModel();
            return View(orderVm);
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderViewModel order)
        {
            if(ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Create");
            
        }
    }
}
