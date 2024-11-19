using LazyLoading_EgarLoading_WebApi.Model;

namespace LazyLoading_EgarLoading_WebApi.Repository
{
    public interface IRepository
    {
        public List<Product> GetProductsLazy();
        public List<Product> GetProductsEgar();
    }
}
