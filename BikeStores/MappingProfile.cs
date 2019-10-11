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
                .ForMember(x => x.Brand, opt => opt.MapFrom(src => src.Brand))
                .ForMember(x => x.Category, opt => opt.MapFrom(src => src.Category))
                .ReverseMap();

            CreateMap<Brands, BrandsDto>();

            CreateMap<Categories, CategoriesDto>();
        }
    }
}
