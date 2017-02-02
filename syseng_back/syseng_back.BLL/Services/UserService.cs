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
    public class UserService : IUserService
    {
        IUnitOfWork context { get; set; }

        public UserService(IUnitOfWork uow)
        {
            context = uow;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public UserDTO GetUser(int id)
        {
            var user = context.Users.Get(id);
            if (user == null)
                throw new ValidationException("User не найден", "");
            Mapper.Initialize(c => c.CreateMap<User, UserDTO>());
            return Mapper.Map<User, UserDTO>(user);
        }

        public UserDTO GetUserByEmailAndPassword(string email, string password)
        {
            var users = context.Users.GetAll();
            var user = users.Where(p => p.Email == email && p.Password == password).FirstOrDefault();
            if(user == null)
                throw new ValidationException("User не найден", "");
            Mapper.Initialize(c => c.CreateMap<User, UserDTO>());
            return Mapper.Map<User, UserDTO>(user);
            //var user = await context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            Mapper.Initialize(c => c.CreateMap<User, UserDTO>());
            return Mapper.Map<IEnumerable<User>, List<UserDTO>>(context.Users.GetAll());
        }

        public UserDTO CreateUser(string email, string password, int roleId)
        {
            //Mapper.Initialize(c => c.CreateMap<User, UserDTO>());
            //IEnumerable<UserDTO> users =  Mapper.Map<IEnumerable<User>, List<UserDTO>>(context.Users.GetAll());

            //UserDTO userDTO = users.Where(p => p.Email == email && p.Password == password).FirstOrDefault();
            //if (user == null)
            //{

            //    user.Email = email;
            //    user.Password = password;
            //    user.RoleId = roleId;
            //    context.Users.Create(user);
            //}
            return null;
        }
    }
}
