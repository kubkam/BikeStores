using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                .ForMember(x => x.BrandDto, opt => opt.MapFrom(src => src.Brand))
                .ForMember(x => x.CategoryDto, opt => opt.MapFrom(src => src.Category));

            CreateMap<Brands, BrandsDto>();

            CreateMap<Categories, CategoriesDto>();
        }
    }
}
