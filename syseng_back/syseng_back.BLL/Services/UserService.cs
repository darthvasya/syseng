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
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            throw new NotImplementedException();
        }

        public UserDTO CreateUser(string email, string password, int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
