using System.ComponentModel.DataAnnotations;

namespace LazyLoading_EgarLoading_WebApi.Model
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
