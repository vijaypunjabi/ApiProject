using ApiProject.Database.Infrastructure;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Database.Repositories
{
    public interface IAccountRepository : IRepository<UserLogin>
    {
        UserLogin Login(string userName, string password);
    }
    public class AccountRepository : Repository<UserLogin>, IAccountRepository
    {

        public AccountRepository(ApiProjectContext apiProjectContext) : base(apiProjectContext)
        {

        }

        public UserLogin Login(string userName, string password)
        {
            UserLogin userLogin = ApiProjectContext.UserLogins.Where(x => x.Name == userName && x.Password == password).FirstOrDefault();
            return userLogin;

        }
}
    
    
   
}
