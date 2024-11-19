using AutoMapper;
using LazyLoading_EgarLoading_WebApi.Dto;
using LazyLoading_EgarLoading_WebApi.Migrations;
using LazyLoading_EgarLoading_WebApi.Model;
using LazyLoading_EgarLoading_WebApi.Repository;

namespace LazyLoading_EgarLoading_WebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

     
        public List<ProductDto> GetProductsEgar()
        {
            var products = _repository.GetProductsEgar();

            return _mapper.Map<List<ProductDto>>(products);
        }

        public List<ProductDto> GetProductsLazy()
        {
          
            var products = _repository.GetProductsLazy();

            
            return _mapper.Map<List<ProductDto>>(products);
        }
    }


}


