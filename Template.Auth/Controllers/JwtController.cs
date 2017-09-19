using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Template.Auth.ExtensionMethods;
using Template.Auth.Global;
using Template.Auth.Interfaces;
using Template.Auth.Models.Security;
using Template.Auth.Processes;
using Template.Auth.Workflows;

namespace Template.Auth.Controllers
{
    [Route("api/[controller]")]
    public class JwtController : Controller
    {
        private readonly JwtIssuerOptions jwtOptions;
        private readonly ILogger logger;
        private readonly JsonSerializerSettings serializerSettings;
        private readonly SecurityWorkflow securityWorkflow;

        public JwtController(IOptions<JwtIssuerOptions> jwtOptions, ILoggerFactory loggerFactory, IUserRepository userRepository, ISecurityRepository securityRepository)
        {
            securityWorkflow = new SecurityWorkflow(userRepository, securityRepository);
            this.jwtOptions = jwtOptions.Value;
            JwtIssuerOptionsProcess.ValidateOptions(this.jwtOptions);

            logger = loggerFactory.CreateLogger<JwtController>();

            serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromForm]Credentials credentials)
        {
            var identity = await securityWorkflow.GetClaimsIdentity(credentials);
            if (identity == null)
            {
                logger.LogInformation("Invalid username or password");
                return BadRequest("Invalid credentials");
            }

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, credentials.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, await jwtOptions.JtiGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat, jwtOptions.IssuedAt.ToUnixEpochDate().ToString(), ClaimValueTypes.Integer64),
                identity.FindFirst(Claims.Key),
                identity.FindFirst(Claims.UserName),
                identity.FindFirst(Claims.Name),
                identity.FindFirst(Claims.Email)
            };

            identity.FindAll(ClaimTypes.Role).ToList().ForEach(_ => claims.Add(_));

            var jwt = new JwtSecurityToken(
                issuer: jwtOptions.Issuer,
                audience: jwtOptions.Audience,
                claims: claims,
                notBefore: jwtOptions.NotBefore,
                expires: jwtOptions.Expiration,
                signingCredentials: jwtOptions.SigningCredentials);

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            var json = JsonConvert.SerializeObject(response, serializerSettings);
            return new OkObjectResult(json);
        }
    }
}