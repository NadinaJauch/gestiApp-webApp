using db.Models;

namespace Abstractions.IRepositories
{
    public interface IMovimientosRepository
    {
        public Task<List<Movimiento>> Get();

        public Task Post(Movimiento movimiento);
    }

}
