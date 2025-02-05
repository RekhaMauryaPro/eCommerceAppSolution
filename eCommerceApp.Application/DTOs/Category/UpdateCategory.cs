using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Application.OTOs.Category
{
    public class UpdateCategory : CategoryBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
