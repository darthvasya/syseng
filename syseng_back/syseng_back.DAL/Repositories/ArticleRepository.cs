using System;
using System.Collections.Generic;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.EF;
using System.Data.Entity;

namespace syseng_back.DAL.Repositories
{
    public class ArticleRepository : IRepository<Article>
    {
        private ApplicationContext _context;

        public ArticleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(Article item)
        {
            _context.Articles.Add(item);
        }

        public void Delete(int id)
        {
            Article article = _context.Articles.Find(id);
            if (article != null)
                _context.Articles.Remove(article);
        }

        public Article Get(int id)
        {
            return _context.Articles.Find(id);
        }

        public IEnumerable<Article> GetAll()
        {
            return _context.Articles;
        }

        public void Update(Article item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
