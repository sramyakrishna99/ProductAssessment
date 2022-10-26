using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class Product
    {

        
        
        
            [Key]
            //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
           
            public Guid ProductId { get; set; }

            [Required]
            public string ProductName { get; set; }



            public string ProductCode { get; set; }



            public int ProductYear { get; set; }



            public int ChannelId { get; set; }



            //public Guid SizeScaleId { get; set; }



            //public List<Article> Article { get; set; }


        
    }
}

