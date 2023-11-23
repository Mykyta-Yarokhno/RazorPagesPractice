using Microsoft.EntityFrameworkCore;
using RazorPagesPractice.Models;

namespace RazorPagesPractice.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<PizzaOrderModel> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
                
        }
    }
}
