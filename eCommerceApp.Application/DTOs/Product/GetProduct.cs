using eCommerceApp.Application.OTOs.Category;
using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Application.OTOs.Product
{
    public class GetProduct : ProductBase 
    {
        [Required]
        public Guid Id { get; set; }
        public GetCategory? Category { get; set; } = new();
    }
}
