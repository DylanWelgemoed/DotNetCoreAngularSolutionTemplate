using System;
using Template.Interface.Repositories;
using Template.Model.Users;

namespace Template.Business.Services
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName), "Must provide a username to search for");

            return userRepository.GetUser(userName);
        }
    }
}