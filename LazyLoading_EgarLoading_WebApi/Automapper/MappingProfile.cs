using AutoMapper;
using LazyLoading_EgarLoading_WebApi.Dto;
using LazyLoading_EgarLoading_WebApi.Model;

namespace LazyLoading_EgarLoading_WebApi.Automapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            {
                // Map Product to ProductDto
                CreateMap<Product, ProductDto>();

                // Map Category to CategoryDto
                CreateMap<Category, CategoryDto>();
            }

        }

    }
}
