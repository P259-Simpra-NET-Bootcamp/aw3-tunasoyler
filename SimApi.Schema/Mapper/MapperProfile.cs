﻿using AutoMapper;
using SimApi.Data;

namespace SimApi.Schema;

public class MapperProfile : Profile 
{
    public MapperProfile()
    {
        CreateMap<Category, CategoryResponse>();
        CreateMap<CategoryRequest, Category>();

        CreateMap<Product, ProductResponse>();
        CreateMap<ProductRequest, Product>();
    }


}
