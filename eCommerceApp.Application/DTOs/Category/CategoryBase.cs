using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Application.OTOs.Category
{
    public class CategoryBase
    {
        [Required]
        public string? Name { get; set; }
    }
}
