using AuthenticationAndAuthorization.Models.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationAndAuthorization.Repostitary
{
    public class TokenHandler:ITokenHandlers
    {
        private readonly IConfiguration configuration;
        public TokenHandler(IConfiguration _cofiguration) 
        { 
            this.configuration = _cofiguration; 
        }
        #region createtokenasync
        public Task<string> CreateTokenAsync(User user)
        {

            //Create Claims
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.GivenName,user.firstname));
            claims.Add(new Claim(ClaimTypes.Surname, user.lastname));
            claims.Add(new Claim(ClaimTypes.Email,user.emailaddress));
            claims.Add(new Claim(ClaimTypes.Name, user.password));
            //loop into roles of users
            user.role.ForEach((role) =>
            {
                claims.Add(new Claim(ClaimTypes.Role,role));
            });

            var keys = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:key"]));
            var credentials = new SigningCredentials(keys,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                configuration["jwt:Issuer"],
                configuration["jwt:Audience"],
               claims,
               expires:DateTime.Now.AddMinutes(15),
               signingCredentials:credentials);
            return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));

            // if the method is async  we can use line 42 instead of line 40
            //return new JwtSecurityTokenHandler().WriteToken(token);

        }
        #endregion
    }
}
