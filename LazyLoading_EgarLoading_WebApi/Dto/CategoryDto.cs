using LazyLoading_EgarLoading_WebApi.Model;

namespace LazyLoading_EgarLoading_WebApi.Dto
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}
