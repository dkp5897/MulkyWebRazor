using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MulkyWebRazor.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Display Order can be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
