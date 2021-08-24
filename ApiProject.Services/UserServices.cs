using ApiProject.Database.Repositories;
using ApiProject.Models;
using System;

namespace ApiProject.Services
{
    public interface IUserServices
    {
        User GetUserDetails();

    }

    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserDetails()
        {
          return _userRepository.GetUserDetails();
        }
    }
}
