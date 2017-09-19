using System.Linq;
using Template.Auth.Interfaces;
using Template.Auth.Models.Security;

namespace Template.Auth.Data.Mock.Repositories
{
    public class SecurityRepository : ISecurityRepository
    {
        public bool AuthenticateCredentials(Credentials credentials)
        {
            return MockData.Credentials.Any(_ => _.UserName.ToLower().Equals(credentials.UserName.ToLower()) && _.Password.Equals(credentials.Password));
        }
    }
}