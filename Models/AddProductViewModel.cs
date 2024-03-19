using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FurntureWebAPP_ASP_NET_CORE_MVC.Models
{
    public class AddProductViewModel
    {
        public IFormFile? ImageFile { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; } = "";
        [Required, MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required, MaxLength(100)]
        public string Category { get; set; } = "";
        [Required, MaxLength(100)]
        public string? Description { get; set; }

        [Required]

        public decimal? Price { get; set; } 
    }
}
