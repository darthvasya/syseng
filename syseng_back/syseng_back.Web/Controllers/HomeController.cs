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
    public class homeController : Controller
    {
        IArticleService _articleService;
        IProjectService _projectService;

        public homeController(IArticleService articleService, IProjectService projectService)
        {
            this._articleService = articleService;
            this._projectService = projectService;
        }

        public ActionResult index()
        {
            IEnumerable<ArticleDTO> articlesDtos = _articleService.GetArticles().Take(3);
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var articles = Mapper.Map<IEnumerable<ArticleDTO>, List<ArticleViewModel>>(articlesDtos);
            ViewBag.Articles = articles;

            IEnumerable<ProjectDTO> projectsDtos = _projectService.GetProjects();
            Mapper.Initialize(c => c.CreateMap<ProjectDTO, ProjectViewModel>());
            var projects = Mapper.Map<IEnumerable<ProjectDTO>, List<ProjectViewModel>>(projectsDtos);
            ViewBag.Projects = projects;

            return View();
        }

        public ActionResult articles()
        {
            IEnumerable<ArticleDTO> articlesDtos = _articleService.GetArticles();
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var articles = Mapper.Map<IEnumerable<ArticleDTO>, List<ArticleViewModel>>(articlesDtos);
            ViewBag.Articles = articles;
            return View();
        }

        public ActionResult article(int id)
        {
            ArticleDTO articleDtos = _articleService.GetArticle(id);
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, ArticleViewModel>());
            var article = Mapper.Map<ArticleDTO, ArticleViewModel>(articleDtos);
            ViewBag.Article = article;
            return View();
        }

        public ActionResult project(int id)
        {
            ProjectDTO projectDtos = _projectService.GetProject(id);
            Mapper.Initialize(c => c.CreateMap<ProjectDTO, ProjectViewModel>());
            var project = Mapper.Map<ProjectDTO, ProjectViewModel>(projectDtos);
            ViewBag.Project = project;
            return View();
        }

        public ActionResult projects()
        {
            IEnumerable<ProjectDTO> projectsDtos = _projectService.GetProjects();
            Mapper.Initialize(c => c.CreateMap<ProjectDTO, ProjectViewModel>());
            var projects = Mapper.Map<IEnumerable<ProjectDTO>, List<ProjectViewModel>>(projectsDtos);
            ViewBag.Projects = projects;
            return View();
        }

        public ActionResult automation()
        {
            return View();
        }

        public ActionResult waterclean()
        {
            return View();
        }

        public ActionResult contacts()
        {
            return View();
        }



        [HttpPost]
        public JsonResult mail(ContactFromModel model)
        {
            string response = "Ok";
            return Json(response);
        }
    }
}