using Template.Auth.Interfaces;
using Template.Auth.Models.Security;

namespace Template.Auth.Data.Integration
{
    public class SecurityRepository : ISecurityRepository
    {
        public bool AuthenticateCredentials(Credentials credentials)
        {
            throw new System.NotImplementedException();
        }
    }
}