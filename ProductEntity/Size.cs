using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class Size
    {
        [Key]
        public Guid SizeId { get; set; }
        public string Name { get; set; }
    }
}
