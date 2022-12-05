using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions.IRepositories;
using Abstractions.IServices;
using db.Models;
using Abstractions;

namespace Services
{
    internal class SeguridadService : ISeguridadService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SeguridadService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Usuario> GetLoginByCredentials(Usuario usuario)
        {
            return await _unitOfWork.SeguridadRepository.GetLoginByCredentials(usuario);
        }

        public async Task RegisterUser(Usuario usuario)
        {
            await _unitOfWork.SeguridadRepository.Add(usuario);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
