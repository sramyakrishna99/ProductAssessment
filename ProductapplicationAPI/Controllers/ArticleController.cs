using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBusiness.Services;
using ProductEntity;
using System;
using System.Collections.Generic;

namespace ProductapplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        private ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpPost("AddArticle")]
        public IActionResult AddArticle([FromBody] Article article)
        {
            _articleService.AddArticle(article);
            return Ok("article created succesfully");
        }
        [HttpGet("GetProduct")]
        public Article GetArticle( Guid id)
        {
            return _articleService.GetArticle(id);
        }

    }
}

