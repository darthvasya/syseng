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
        IUserService userService;

        public HomeController(IUserService _userService)
        {
            this.userService = _userService;
        }

        public ActionResult Index()
        {
            IEnumerable<UserDTO> userDtos = userService.GetUsers();
            Mapper.Initialize(c => c.CreateMap<UserDTO, UserViewModel>());
            var users = Mapper.Map<IEnumerable<UserDTO>, List<UserViewModel>>(userDtos);   
            return View(users);
        }

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