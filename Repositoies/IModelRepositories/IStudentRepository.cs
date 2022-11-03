using School_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Repositoies
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Mark> GetStudentNHighestMarks(int count);
        IEnumerable<Student> GetStudentLowestMarks(int count);
    }
}
