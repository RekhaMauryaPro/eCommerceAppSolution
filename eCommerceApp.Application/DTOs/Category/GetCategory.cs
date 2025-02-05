using eCommerceApp.Application.OTOs.Product;

namespace eCommerceApp.Application.OTOs.Category
{
    public class GetCategory:CategoryBase
    {
        public Guid Id { get; set; }
        public ICollection<GetProduct>? Products { get; set; }
    }
}
