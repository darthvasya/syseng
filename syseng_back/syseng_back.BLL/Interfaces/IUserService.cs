using syseng_back.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.BLL.Interfaces
{
    public interface IUserService
    {
        UserDTO CreateUser(string email, string password, int roleId);
        UserDTO GetUser(int id);
        UserDTO GetUserByEmailAndPassword(string email, string password);
        IEnumerable<UserDTO> GetUsers();
        void Dispose();
    }
}
