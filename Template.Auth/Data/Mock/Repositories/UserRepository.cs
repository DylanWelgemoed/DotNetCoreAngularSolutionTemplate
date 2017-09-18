using System.Linq;
using Template.Auth.Interfaces;
using Template.Auth.Models;

namespace Template.Auth.Data.Mock.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUser(string userName)
        {
            return MockData.Users.FirstOrDefault(_ => _.UserName.ToLower().Equals(userName.ToLower()));
        }
    }
}