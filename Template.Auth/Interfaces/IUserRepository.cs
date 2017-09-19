using Template.Auth.Models.Users;

namespace Template.Auth.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(string userName);
    }
}