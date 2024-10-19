using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MulkyWebRazor.Data;

namespace MulkyWebRazor.Pages.Category
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Model.Category? Category { get; set; }
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if (id != null || id != 0)
            {
                Category = _context.Category.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Category.Update(Category);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
