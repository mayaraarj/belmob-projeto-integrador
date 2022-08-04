using Belmob.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Belmob.Services
{
    public class TokenService
    {
        public static string GerarChaveToken(Pessoa pessoa)
        {
            var token = new JwtSecurityTokenHandler();
            var assinatura = Encoding.ASCII.GetBytes(Ambiente.Chave);
            var corpo = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, pessoa.Email.ToString()),
                    new Claim(ClaimTypes.Role, pessoa.Nome.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(assinatura),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var chave = token.CreateToken(corpo);

            return token.WriteToken(chave);
        }
    }
}
