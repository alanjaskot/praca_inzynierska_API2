using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PracaInzynierskaAPI.API.JWT.Helpers;
using PracaInzynierskaAPI.API.JWT.Interfaces;
using PracaInzynierskaAPI.API.JWT.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.API.JWT
{
    public class JwtService: IJwtService
    {
        private readonly IOptions<JwtOptions> _options;
        private readonly SigningCredentials _signingCredentials;


        public JwtService(IOptions<JwtOptions> options)
        {
            _options = options;
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Helper.SECRET_KEY));
            _signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        }

        public Task<JwtAuthenticationTokenModel> CreateToken(Guid userId)
        {
            if (Guid.Empty == userId)
                return Task.FromResult<JwtAuthenticationTokenModel>(null);

            var now = DateTime.UtcNow;
            var nowEpoch = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var jwtClaims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, nowEpoch.ToString())
            };

            var expires = now.AddHours(_options.Value.ExpiryHours);
            var jwt = new JwtSecurityToken(
                issuer: _options.Value.Issuer,
                claims: jwtClaims,
                notBefore: now,
                expires: expires,
                signingCredentials: _signingCredentials
            );

            return Task.FromResult(
                new JwtAuthenticationTokenModel(
                    "Bearer",
                    new JwtSecurityTokenHandler().WriteToken(jwt)
                    )
                );
        }
    }
}
