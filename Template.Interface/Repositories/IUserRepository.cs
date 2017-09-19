using Template.Model.Users;

namespace Template.Interface.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string userName);
    }
}