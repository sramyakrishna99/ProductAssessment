using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Repository
{
    public interface ISizeRepository
    {
        void AddSize(Size size);
        Size GetSize(Guid Sizeid);
    }
}
