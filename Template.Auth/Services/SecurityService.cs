using System;
using Template.Auth.Interfaces;
using Template.Auth.Models.Security;

namespace Template.Auth.Services
{
    public class SecurityService
    {
        private readonly ISecurityRepository SecurityRepository;

        public SecurityService(ISecurityRepository securityRepository)
        {
            SecurityRepository = securityRepository;
        }

        public bool AuthenticateCredentials(Credentials credentials)
        {
            if (credentials == null)
                throw new ArgumentNullException(nameof(credentials), "Must supply valid credentials to authenticate");

            return SecurityRepository.AuthenticateCredentials(credentials);
        }
    }
}