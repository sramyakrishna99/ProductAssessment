using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductEntity;


namespace ProductData.Repository
{
    public class SizeRepository : ISizeRepository
    {
        ProductDbContext _sizeDbContext;
       
        public void AddSize(Size size)
        {
            _sizeDbContext.size.Add(size);
            _sizeDbContext.SaveChanges();
        }


        public Size GetSize(Guid Sizeid)
        {
            return _sizeDbContext.size.Find(Sizeid);
        }
    }
}
