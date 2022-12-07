using db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.IRepositories
{
    public interface IMovimientosRepository<M> where M : Movimiento
    {
        public  Task<List<M>> Get();

        public  Task Post(M movimiento);

        //heredados de base
        public Task Add(M movimiento);

        public IEnumerable<M> GetAll();

        public  Task<M> GetById(int id);

        public void Update(M movimiento);

        public Task Delete(int id);
    }
}
