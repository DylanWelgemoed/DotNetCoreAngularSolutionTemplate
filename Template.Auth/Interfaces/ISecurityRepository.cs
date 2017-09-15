using Template.Auth.Models;

namespace Template.Auth.Interfaces
{
    public interface ISecurityRepository
    {
        bool AuthenticateCredentials(Credentials credentials);
    }
}