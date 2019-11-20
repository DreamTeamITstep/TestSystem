using System;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Dapper;
using Microsoft.IdentityModel.Tokens;
using TestSystem.Common;

namespace TestSystem.Server.Services
{
    public interface IAuthService
    {
        string Authenticate(string username, string password);
    }

    public class AuthService: IAuthService
    {
        private readonly SqlConnection _sqlConnection;
        
        public AuthService(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public string Authenticate(string username, string password)
        {
            var users = _sqlConnection.Query<User>(@"
                SELECT Id as Id, FullName as Login, Password as Password, 'Admin' as Role FROM Admin
                UNION ALL
                SELECT Id as Id, FullName as Login, Password as Password, 'Teacher' as Role FROM Teacher
                UNION ALL
                SELECT Id as Id, FullName as Login, Password as Password, 'Student' as Role FROM Student");
            
            var user = users.Single(x => x.Login == username && x.Password == password);

            var tokenHandler = new JwtSecurityTokenHandler();
            //TODO Move secret to settings
            var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}