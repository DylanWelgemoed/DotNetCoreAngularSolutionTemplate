using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Template.Auth.Interfaces;
using Template.Auth.Models;
using IntegrationRepos = Template.Auth.Data.Integration;
using MockRepos = Template.Auth.Data.Mock.Repositories;

namespace Template.Auth
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
            services.AddOptions();

            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtAppSettingOptions["SecretKey"])), SecurityAlgorithms.HmacSha256);
            });

            SetInterfaces(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

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
            services.AddTransient<ISecurityRepository, MockRepos.SecurityRepository>();
        }

        private void SetIntegrationInterfaces(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, IntegrationRepos.UserRepository>();
            services.AddTransient<ISecurityRepository, IntegrationRepos.SecurityRepository>();
        }

        #endregion Dependency Injection
    }
}