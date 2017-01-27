using AutoMapper;
using syseng_back.BLL.DTO;
using syseng_back.BLL.Interfaces;
using syseng_back.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace syseng_back.Web.Controllers
{
    public class HomeController : Controller
    {
        IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            this._articleService = articleService;
        }

        public ActionResult Index()
        {
            IEnumerable<ArticleDTO> articlesDtos = _articleService.GetArticles().Take(3);
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var articles = Mapper.Map<IEnumerable<ArticleDTO>, List<ArticleViewModel>>(articlesDtos);
            ViewBag.Articles = articles;

            return View();
        }

        public ActionResult Articles()
        {
            IEnumerable<ArticleDTO> articlesDtos = _articleService.GetArticles();
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var articles = Mapper.Map<IEnumerable<ArticleDTO>, List<ArticleViewModel>>(articlesDtos);
            ViewBag.Articles = articles;
            return View();
        }

        public ActionResult Article(int id)
        {
            ArticleDTO articleDtos = _articleService.GetArticle(id);
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var article = Mapper.Map<ArticleDTO, ArticleViewModel>(articleDtos);
            ViewBag.Article = article;
            return View();
        }
    }
}