using ProductData.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBusiness.Services
{
    public class SizeService
    {
        ISizeRepository _sizeRepository;
        public SizeService(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }   

        public void Addsize(Size size)
        {
            Guid guid = Guid.NewGuid();
            size.SizeId = guid;
            _sizeRepository.AddSize(size);
        }
        public Size GetSize(Guid id)
        {
            return _sizeRepository.GetSize(id);
        }
    }
}
