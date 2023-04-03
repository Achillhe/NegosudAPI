using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NegosudAPI.Data;
using NegosudAPI.Services.AuthentificationService;
using Org.BouncyCastle.Crypto.Generators;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BusinessLayer.Services.AuthentificationService
{
    public class JwtAuthentificationService : IJwtAuthentificationService
    {

        private readonly DataContext _context;

        public JwtAuthentificationService(DataContext context)
        {
            _context = context;
        }

        public string GenerateToken(string secret, List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(
                    key,
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<Client?> Login(string Email, string MotDePasse)
        {
            var client = await _context.Clients.SingleOrDefaultAsync(c => c.Email == Email);
            if (client is null || !BCrypt.Net.BCrypt.Verify(MotDePasse, client.MotDePasse))
                return null;

            return client;
        }
    }
}
