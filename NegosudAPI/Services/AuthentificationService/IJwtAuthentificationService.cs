using System.Security.Claims;

namespace NegosudAPI.Services.AuthentificationService
{
    public interface IJwtAuthentificationService
    {
        Task<Client?> Login(string Email, string MotDePasse);
        string GenerateToken(string secret, List<Claim> claims);
    }
}
