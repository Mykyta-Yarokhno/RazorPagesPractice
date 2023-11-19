using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPractice.Models;

namespace RazorPagesPractice.Pages.Forms
{
    public class CustomPizaaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public void OnGet()
        {
        }
    }
}
