using ProductData.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBusiness.Services
{
    public class ArticleService
    {
        IArticleRepository _articleRepository;
       
       public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void AddArticle(Article Article)
        {
            Guid Aid = Guid.NewGuid();
            Article.ArticleId = Aid;
            _articleRepository.AddArticle(Article);
        }
        public Article GetArticle(Guid id)
        {
            return _articleRepository.GetArticle(id);
        }
    }
}
