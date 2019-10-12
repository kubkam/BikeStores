using AutoMapper;
using BikeStores.Core;
using BikeStores.Dto;

namespace BikeStores
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductsDto>()
                .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.Brand.BrandId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.CategoryId))
                .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.BrandName))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));

            CreateMap<Brands, BrandsDto>();
            CreateMap<Categories, CategoriesDto>();

            CreateMap<ProductsDto, Products>();

            CreateMap<BrandsDto, Brands>();
            CreateMap<CategoriesDto, Categories>();
        }
    }
}
