
using LazyLoading_EgarLoading_WebApi.Data;
using LazyLoading_EgarLoading_WebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LazyLoading_EgarLoading_WebApi.Repository
{
    public class Repositories : IRepository
    {
        private readonly Context _context;

        public Repositories(Context context)
        {
            _context = context;
        }

        // Eager loading: Explicitly including the Category in the query
        public List<Product> GetProductsEgar()
        {
            return _context.products.Include(p => p.Category).ToList();
        }

        // Lazy loading: This will load Category when accessed (because it's virtual)
        public List<Product> GetProductsLazy()
        {
            return _context.products.ToList(); // Lazy loading will load the Category on demand
        }
    }

}
