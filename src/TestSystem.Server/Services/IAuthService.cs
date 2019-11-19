using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TestSystem.Common;

namespace WebApiServer.Services
{
    public interface IAuthService
    {
        string Authenticate(string username, string password);
    }

    public class AuthService: IAuthService
    {
        private readonly IEnumerable<User> _users;
        
        public AuthService()
        {
            _users = new[]
            {
                new User {Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test"}
            };
        }
        public string Authenticate(string username, string password)
        {
            var user = _users.Single(x => x.Username == username && x.Password == password);

            var tokenHandler = new JwtSecurityTokenHandler();
            //TODO Move secret to settings
            var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}