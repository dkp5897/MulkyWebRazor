using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MulkyWebRazor.Data;

namespace MulkyWebRazor.Pages.Category
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        //[BindProperty]
        public Model.Category Category { get; set; }
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Category.Add(Category);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
