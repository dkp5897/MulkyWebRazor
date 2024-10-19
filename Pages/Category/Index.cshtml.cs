using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MulkyWebRazor.Data;

namespace MulkyWebRazor.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Model.Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;    
        }
        public void OnGet()
        {
            Categories = _context.Category.ToList();
        }
    }
}
