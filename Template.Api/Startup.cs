using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Text;
using Template.Interface.Repositories;
using IntegrationRepos = Template.Integration.Repositories;
using MockRepos = Template.Mock.Repositories;

namespace Template.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            SetAuthentication(services);
            SetInterfaces(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }

        #region Authentication

        private void SetAuthentication(IServiceCollection services)
        {
            var jwtAppSettingOptions = Configuration.GetSection("JwtIssuerOptions");
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.ClaimsIssuer = jwtAppSettingOptions["Issuer"];
                        options.Audience = jwtAppSettingOptions["Audience"];
                        options.IncludeErrorDetails = true;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            ValidateAudience = false,
                            ValidateIssuer = false,
                            IssuerSigningKeys = new List<SecurityKey>
                            {
                                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtAppSettingOptions["SecretKey"]))
                            },
                            ValidateLifetime = true
                        };
                        options.RequireHttpsMetadata = false;
                        options.Events = new JwtBearerEvents
                        {
                            OnAuthenticationFailed = c =>
                            {
                                c.NoResult();
                                c.Response.StatusCode = 401;
                                c.Response.ContentType = "text/plain";
                                return c.Response.WriteAsync(c.Exception.ToString());
                            }
                        };
                    });
        }

        #endregion Authentication

        #region Dependency Injection

        private void SetInterfaces(IServiceCollection services)
        {
#if DEBUG
            SetMockInterfaces(services);
#else
            SetIntegrationInterfaces(services);
#endif
        }

        private void SetMockInterfaces(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, MockRepos.UserRepository>();
        }

        private void SetIntegrationInterfaces(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, IntegrationRepos.UserRepository>();
        }

        #endregion Dependency Injection
    }
}