using System.Linq;
using Template.Interface.Repositories;
using Template.Model.Users;

namespace Template.Mock.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUser(string userName)
        {
            return MockData.Users.FirstOrDefault(_ => _.UserName.ToLower().Equals(userName.ToLower()));
        }
    }
}