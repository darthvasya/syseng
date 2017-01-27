using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace syseng_back.Web.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ShortBody { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public int CountView { get; set; }
    }
}