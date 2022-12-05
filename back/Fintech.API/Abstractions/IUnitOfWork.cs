using db.Models;
using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {


        ISeguridadRepository SeguridadRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}

