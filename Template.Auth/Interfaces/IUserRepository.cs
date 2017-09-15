using Template.Auth.Models;

namespace Template.Auth.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(string userName);
    }
}