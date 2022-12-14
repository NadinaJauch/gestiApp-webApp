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
using AutoMapper;

namespace Services
{
    public class SeguridadService : ISeguridadService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IPasswordService _passwordService;
        private readonly IMapper _mapper;

        public SeguridadService(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper, IPasswordService passwordService)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _mapper = mapper;
            _passwordService = passwordService;
        }

        public async Task<Usuario> GetLoginByCredentials(Usuario usuario)
        {
            return await _unitOfWork.SeguridadRepository.GetLoginByCredentials(usuario);
        }

        public async Task<string> LoginAsync(SeguridadDto loginDto)
        {
           var user =  await _unitOfWork.SeguridadRepository.getUserWithMail(loginDto.Mail);
            if (user == null)
            {
                return "";
            }
            if ((user.Mail.ToLower() == loginDto.Mail.ToLower()) && (user.Password == loginDto.Password))
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.Mail),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"])), 
                        SecurityAlgorithms.HmacSha256)
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            return "";
        }

        public async Task RegisterUser(UsuarioRegisterDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            usuario.FirstName = usuarioDTO.FirstName;
            usuario.LastName = usuarioDTO.LastName;
            usuario.Mail = usuarioDTO.Mail;
            usuario.Password = _passwordService.Hash(usuarioDTO.Password);
            usuario.DateJoined = DateTime.Now;
            usuario.LastLogin = DateTime.Now;

            try
            {
                await _unitOfWork.SeguridadRepository.Add(usuario);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }
    }
}
