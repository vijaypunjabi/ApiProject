using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Database.Repositories
{
    public interface IUserRepository
    {
        User GetUserDetails();
    }
    public class UserRepository : IUserRepository
    {
        public User GetUserDetails()
        {
            User user = new User();
            user.Id = 1;
            user.Name = "VIJAY";
            user.Age = 22;
            return user;
        }
    }
}
