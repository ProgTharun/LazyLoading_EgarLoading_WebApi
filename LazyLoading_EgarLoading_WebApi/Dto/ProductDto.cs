﻿namespace LazyLoading_EgarLoading_WebApi.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public string Catagories { get; set; }  
    }
}
