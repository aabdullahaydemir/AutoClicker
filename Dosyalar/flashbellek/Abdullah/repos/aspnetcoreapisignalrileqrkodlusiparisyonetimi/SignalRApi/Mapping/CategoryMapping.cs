using AutoMapper;
using SignalRApi.EntityLayer.Entities;
using SignalR.Entitylayer.Entities;
using SignalR.DtoLayer.CategoryDto;

namespace SignalRApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
