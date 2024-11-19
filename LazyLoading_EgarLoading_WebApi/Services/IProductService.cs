using LazyLoading_EgarLoading_WebApi.Dto;
using LazyLoading_EgarLoading_WebApi.Model;

namespace LazyLoading_EgarLoading_WebApi.Services
{
    public interface IProductService
    {
        public List<ProductDto> GetProductsLazy();
        public List<ProductDto> GetProductsEgar();
    }
}
