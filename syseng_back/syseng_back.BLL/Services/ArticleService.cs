using AutoMapper;
using syseng_back.BLL.DTO;
using syseng_back.BLL.Infrastructure;
using syseng_back.BLL.Interfaces;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.BLL.Services
{
    public class ArticleService : IArticleService
    {
        IUnitOfWork _context { get; set; }

        public ArticleService(IUnitOfWork uow)
        {
            _context = uow;
        }

        public void AddArticle(ArticleDTO article)
        {
            Mapper.Initialize(c => c.CreateMap<ArticleDTO, Article>());
            _context.Articles.Create(Mapper.Map<ArticleDTO, Article>(article));
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ArticleDTO GetArticle(int id)
        {
            var article = _context.Articles.Get(id);
            Mapper.Initialize(c => c.CreateMap<Article, ArticleDTO>());
            return Mapper.Map<Article, ArticleDTO>(article);
        }

        public IEnumerable<ArticleDTO> GetArticles()
        {
            Mapper.Initialize(c => c.CreateMap<Article, ArticleDTO>());
            return Mapper.Map<IEnumerable<Article>, List<ArticleDTO>>(_context.Articles.GetAll());
        }

        public void RemoveArticle(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateArticle(ArticleDTO article)
        {
            throw new NotImplementedException();
        }
    }
}
