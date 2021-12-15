using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PracaInzynierskaAPI.API.JWT.Interfaces;
using PracaInzynierskaAPI.API.JWT.Validators;
using System;
using System.Text;

namespace PracaInzynierskaAPI.API.JWT
{
    public static class JwtResponse
    {

        public static void AddJwt(this IServiceCollection services)
        {
            IConfiguration configuration;

            using (var serviceProvider = services.BuildServiceProvider())
            {
                configuration = serviceProvider.GetService<IConfiguration>();
            }

            var jwtSection = configuration.GetSection("jwtBearer");
            services.Configure<JwtOptions>(jwtSection);

            var options = new JwtOptions();
            jwtSection.Bind(options);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(config =>
                {
                    config.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.SecretKey)),
                        ValidIssuer = options.Issuer,
                        ValidAudience = options.ValidAudience,
                        ValidateAudience = options.ValidateAudience,
                        ValidateLifetime = options.ValidateLifetime,
                        LifetimeValidator = TokenLifeTimeValidator.Validate,
                        ClockSkew = TimeSpan.Zero
                    };
                });


            services.AddSingleton<IJwtService, JwtService>();
        }
    }
}
