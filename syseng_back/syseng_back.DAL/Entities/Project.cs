using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.DAL.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public int CountView { get; set; }
        public string Customer { get; set; }
        public string CustomerUrl { get; set; }
        
        public int ProjectTypeId { get; set; }
        public ProjectType ProjectTypre { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
