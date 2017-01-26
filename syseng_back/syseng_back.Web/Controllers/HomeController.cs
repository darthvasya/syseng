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
            IEnumerable<ArticleDTO> articlesDtos = _articleService.GetArticles();
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var articles = Mapper.Map<IEnumerable<ArticleDTO>, List<ArticleViewModel>>(articlesDtos);
            ViewBag.Articles = articles;   
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}