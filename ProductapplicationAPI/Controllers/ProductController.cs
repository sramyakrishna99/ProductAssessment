using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBusiness.Services;
using ProductEntity;
using System;
using System.Collections.Generic;

namespace ProductapplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok("product created succesfully");
        }
        [HttpGet("GetProduct")]
        public Product GetProduct(Guid id)
        {
            return _productService.GetProduct(id);
        }
    }
}
