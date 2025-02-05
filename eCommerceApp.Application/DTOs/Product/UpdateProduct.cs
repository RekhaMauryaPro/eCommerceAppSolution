using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Application.OTOs.Product
{
    public class UpdateProduct:ProductBase
    {
        [Required]
        public Guid Id { get; set; }

    }
}
