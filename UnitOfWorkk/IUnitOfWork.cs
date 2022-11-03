using School_Management_System.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.IUnitOfWorkk
{
    internal interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        int Complete();
    }
}
