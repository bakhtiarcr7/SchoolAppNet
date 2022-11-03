using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Repositoies;

namespace School_Management_System.Unitofwork
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        int Complete();
    }
}
