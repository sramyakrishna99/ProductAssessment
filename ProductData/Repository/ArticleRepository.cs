using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        
        ProductDbContext _articleDbContext;
        public ArticleRepository(ProductDbContext articleDbContext)
        {
            _articleDbContext = articleDbContext;
        }
        public void AddArticle(Article article)
        {
            _articleDbContext.article.Add(article);
            _articleDbContext.SaveChanges();
        }

        public Article GetArticle(Guid id)
        {
            return _articleDbContext.article.Find(id);
        }

       
    }
}
