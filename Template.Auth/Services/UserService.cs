using System;
using Template.Auth.Interfaces;
using Template.Auth.Models.Users;

namespace Template.Auth.Services
{
    public class UserService
    {
        private readonly IUserRepository UserRepository;

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public User GetUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName), "Must supply a valid username to search for");

            return UserRepository.GetUser(userName);
        }
    }
}