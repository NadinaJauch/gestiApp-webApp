using Abstractions.IRepositories;
using Abstractions.IServices;
using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuariosService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Usuario> GetUserById(int Id)
        {
            return await _unitOfWork.UsuariosRepository.ObtenerUsuarioPorId(Id);
        }
    }
}
