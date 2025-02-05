using AutoMapper;
using eCommerceApp.Application.OTOs.Category;
using eCommerceApp.Application.OTOs.Product;
using eCommerceApp.Domain.Entities;

namespace eCommerceApp.Application.Mapping
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<CreateCategory, Category>();
            CreateMap<CreateProduct, Product>();
            CreateMap<Category, GetCategory>();
            CreateMap<Product, GetProduct>();
        }
    }
}
