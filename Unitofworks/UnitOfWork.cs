using School_Management_System.Data;
using School_Management_System.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Unitofwork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolAppContext _context;
        public IStudentRepository Students { get; private set; }

        public UnitOfWork(SchoolAppContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
