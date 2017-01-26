using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace syseng_back.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}