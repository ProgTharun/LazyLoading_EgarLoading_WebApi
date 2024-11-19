using LazyLoading_EgarLoading_WebApi.Data;
using LazyLoading_EgarLoading_WebApi.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LazyLoading_EgarLoading_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("Lazy")]
        public IActionResult GetProductsLazy()
        {
            var products = _productService.GetProductsLazy();
            return Ok(products);
        }

        [HttpGet("Egar")]
        public IActionResult GetCategoryEgar()
        {
            var products = _productService.GetProductsEgar();
            return Ok(products);
        }
    }


}
