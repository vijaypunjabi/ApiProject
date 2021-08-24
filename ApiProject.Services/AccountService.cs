using ApiProject.Database.Repositories;
using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services
{
    public interface IAccountService
    {
        UserLogin Login(string userName, string password);
    }
   public  class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public UserLogin Login(string userName , string password)
        {
            return _accountRepository.Login(userName, password);
        }

    }
}
