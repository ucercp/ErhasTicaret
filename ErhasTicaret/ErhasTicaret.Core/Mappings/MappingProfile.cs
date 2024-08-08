using AutoMapper;
using ErhasTicaret.Core.DTOs;
using ErhasTicaret.Domain.Models;

namespace ErhasTicaret.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<BasketItem, BasketDTO>().ReverseMap();
        }
    }
}
