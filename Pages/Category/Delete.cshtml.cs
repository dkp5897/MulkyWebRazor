using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MulkyWebRazor.Data;

namespace MulkyWebRazor.Pages.Category
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Model.Category? Category { get; set; }
        public DeleteModel(ApplicationDbContext context)
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
            Model.Category? category = _context.Category.Find(Category.CategoryId);
            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
