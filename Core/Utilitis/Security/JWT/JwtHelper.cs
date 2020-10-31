using Core.Entities.ConCreate;
using Core.Extension;
using Core.Utilitis.Security.JWT.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Utilitis.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
            _tokenOptions = configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
        }
        public AccessToken CreateToken(Users user, List<UserClaims> claims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialHelper.CreateSigningCredentials(securityKey);
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var jwt = CreateJwtSecurityToken(tokenOptions: _tokenOptions, user: user,signingCredentials:signingCredentials, userClaims: claims);
            var JwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = JwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken
            {
                Token = token,
                Expiration=_accessTokenExpiration           

            };
        }
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, Users user, SigningCredentials signingCredentials, List<UserClaims> userClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer:tokenOptions.Issuer,
                audience:tokenOptions.Audience,
                expires:_accessTokenExpiration,
                notBefore:DateTime.Now,
                claims:SetClaims(user,userClaims),
                signingCredentials:signingCredentials                
                );
            return jwt;
        }
        private IEnumerable<Claim> SetClaims(Users users,List<UserClaims> userClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentityfier(users.Id.ToString());
            claims.AddEmail(users.EmailAdress);
            claims.AddName($"{users.FirstName} {users.LastName}");
            claims.AddRoles(userClaims.Select(x => x.Name).ToArray());
            return claims;
        }
    }
}
