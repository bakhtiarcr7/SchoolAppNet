using School_Management_System.Data;
using School_Management_System.Repositoies;
using School_Management_System.Repositoies.IModelRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.IUnitOfWorkk
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolAppContext _context;
        public IStudentRepository Students { get; private set; }
        public IMarkRepository Marks { get; private set; }
        public ISubjectRepository Subjects { get; private set; }
        public IGroupRepository Groups { get; private set; }
        public ITeacherRepository Teachers { get; private set; }
        public UnitOfWork(SchoolAppContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
            Marks = new MarkRepository(_context);
            Subjects = new SubjectRepository(_context); 
            Teachers = new TeacherRepository(_context);
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
