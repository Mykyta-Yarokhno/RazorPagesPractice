using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPractice.Data;
using RazorPagesPractice.Models;

namespace RazorPagesPractice.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrderModel> PizzaOrders = new List<PizzaOrderModel>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
     
        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
