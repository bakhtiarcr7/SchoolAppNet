using School_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Repositoies.IModelRepositories
{
    public interface ISubjectRepository
    {
        int GetSubjectCount();
        bool isSubAvailable(string name);
       
    }
}
