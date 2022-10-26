using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        Product GetProduct(Guid id);
    }
}
