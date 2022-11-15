using School_Management_System.Repositoies;
using School_Management_System.Repositoies.IModelRepositories;
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
        ITeacherRepository Teachers { get; }
        ISubjectRepository Subjects { get; }
        IGroupRepository Groups { get; }
        IMarkRepository Marks { get; }

        int Complete();
    }
}
