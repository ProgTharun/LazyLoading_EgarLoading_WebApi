using LazyLoading_EgarLoading_WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace LazyLoading_EgarLoading_WebApi.Data
{
    public class Context : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}

