using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions.IRepositories;
using Abstractions.IServices;
using db.Models;
using Abstractions;
using Views.DTOs;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    internal class SeguridadService : ISeguridadService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public SeguridadService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<Usuario> GetLoginByCredentials(Usuario usuario)
        {
            return await _unitOfWork.SeguridadRepository.GetLoginByCredentials(usuario);
        }

        public async Task<string> LoginAsync(SeguridadDto loginDto)
        {
           var user =  await _unitOfWork.SeguridadRepository.getUserWithMail(loginDto.Mail);
            if ((user.Mail == loginDto.Mail) && (user.Password == loginDto.Password))
            {
                var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Mail),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
                var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            return null;
        }

        public async Task RegisterUser(Usuario usuario)
        {
            await _unitOfWork.SeguridadRepository.Add(usuario);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
