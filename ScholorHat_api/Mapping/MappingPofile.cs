using AutoMapper;
using ScholorHat_api.DTOs;
using ScholorHat_api.Models;
using ScholorHat_api.ViewModels;

namespace ScholorHat_api.Mapping
{
    public class MappingPofile : Profile
    {
        public MappingPofile()
        {

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<ProductUpdateDTO, Product>();
            CreateMap<Category, CategoryDTO>();



        }
    }

}
