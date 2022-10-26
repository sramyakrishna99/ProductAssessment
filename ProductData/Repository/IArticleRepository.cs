using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(Article article);
        Article GetArticle(Guid id);
    }
}
