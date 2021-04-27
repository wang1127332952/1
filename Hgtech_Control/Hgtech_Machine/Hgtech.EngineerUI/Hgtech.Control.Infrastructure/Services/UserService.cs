using Hgtech.Control.Infrastructure.IServices;
using Hgtech.Control.Infrastructure.Models;
using System.Collections.Generic;

namespace Hgtech.Control.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            var allUsers = new List<User>()
           {
               new User(){Id=1,LoginId="Admin",PassWord="Admin123"},
               new User(){Id=1,LoginId="Ryzen",PassWord="123456"},
               new User(){Id=1,LoginId="Test",PassWord="Test123"},
           };
            return allUsers;
        }
    }
}
