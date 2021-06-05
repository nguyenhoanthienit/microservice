using Common.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Auth.Infrastructure.Configures
{
	public static class AuthenticationConfig
	{
		public static IServiceCollection AddAuth(this IServiceCollection services)
		{
			JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = IdentityConstants.ApplicationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.Authority = Environment.GetEnvironmentVariable("IDENTITY_SERVICES_URL");
				options.RequireHttpsMetadata = true;
				options.TokenValidationParameters = new TokenValidationParameters()
				{
					ValidateAudience = false
				};
				options.RequireHttpsMetadata = false;
			});

			services.AddAuthorization(options =>
			{
				options.AddPolicy(Policies.API_SCOPE, policy =>
				{
					policy.RequireAuthenticatedUser();
					policy.RequireClaim("scope", ApiScopes.API);
				});
			});

			return services;
		}
	}
}