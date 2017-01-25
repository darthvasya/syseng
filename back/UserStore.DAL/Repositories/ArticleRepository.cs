using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.EF;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
