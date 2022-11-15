using School_Management_System.Data;
using School_Management_System.Models;
using School_Management_System.Repositoies.IModelRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Repositoies
{
    internal class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SchoolAppContext SchoolAppContext
        {
            get { return Context as SchoolAppContext; }
        }
        public SubjectRepository(SchoolAppContext context) : base(context)
        {
        }

        public int GetSubjectCount()
        {
            var total = SchoolAppContext.Subjects.ToArray().Length;
            Console.WriteLine("Total Subjects are : " + total);
            return total;
        }

        public bool isSubAvailable(string name)
        {
            var getItem = SchoolAppContext.Subjects.Where(x => x.Title.Equals(name)).FirstOrDefault();

            if (getItem != null)
            {
                Console.WriteLine($"Yes Subject {name} is Present");
                return true;
            }
            Console.WriteLine($"NO Subject with name {name} Found: 404!");
            return false;

        }
    }
}
