using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{

   
    public class Article
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ArticleId { get; set; }

        public string ArticleName { get; set; }



        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }



        [ForeignKey("Colour")]
        public Guid ColourId { get; set; }
        public Colour Colour { get; set; }
    }
}
