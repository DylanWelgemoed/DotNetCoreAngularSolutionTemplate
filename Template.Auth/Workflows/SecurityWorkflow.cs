using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Template.Auth.Global;
using Template.Auth.Interfaces;
using Template.Auth.Models;
using Template.Auth.Services;

namespace Template.Auth.Workflows
{
    public class SecurityWorkflow
    {
        private readonly UserService userService;
        private readonly SecurityService securityService;

        public SecurityWorkflow(IUserRepository userRepository, ISecurityRepository securityRepository)
        {
            userService = new UserService(userRepository);
            securityService = new SecurityService(securityRepository);
        }

        public Task<ClaimsIdentity> GetClaimsIdentity(Credentials credentials)
        {
            if (securityService.AuthenticateCredentials(credentials))
            {
                var user = userService.GetUser(credentials.UserName);
                var claims = new[]
                {
                    new Claim(Claims.UserName, user.UserName),
                    new Claim(Claims.Name, $"{user.FirstName} {user.LastName}"),
                    new Claim(Claims.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.IsAdmin ? UserRole.Administrator : UserRole.User)
                };

                return Task.FromResult(new ClaimsIdentity(new GenericIdentity(credentials.UserName, "Token"), claims));
            }

            return Task.FromResult<ClaimsIdentity>(null);
        }
    }
}