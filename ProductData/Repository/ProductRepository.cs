using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductDbContext _productDbContext;
        public ProductRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public void AddProduct(Product product)
        {
             Guid Pid = Guid.NewGuid();
             product.ProductId = Pid;
            _productDbContext.product.Add(product);
            _productDbContext.SaveChanges();
        }


        public Product GetProduct(Guid id)
        {
            return _productDbContext.product.Find(id);
        }
    }

}
