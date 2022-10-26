using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class Colour
    {
        [Key]
        public Guid ColourId { get; set; }
        public string Code { get; set; } 
        public string Name { get; set; } 
        
    }
}
