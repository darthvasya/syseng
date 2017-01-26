using syseng_back.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.BLL.Interfaces
{
    public interface IArticleService
    {
        ArticleDTO GetArticle(int id);
        IEnumerable<ArticleDTO> GetArticles();
        void AddArticle(ArticleDTO article);
        void RemoveArticle(int id);
        void UpdateArticle(ArticleDTO article);
        void Dispose();
    }
}
