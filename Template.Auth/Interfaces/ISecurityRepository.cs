using Template.Auth.Models.Security;

namespace Template.Auth.Interfaces
{
    public interface ISecurityRepository
    {
        bool AuthenticateCredentials(Credentials credentials);
    }
}