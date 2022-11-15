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
    internal class MarkRepository:Repository<Mark>,IMarkRepository
    {
        public SchoolAppContext SchoolAppContext
        {
            get { return Context as SchoolAppContext; }
        }
        public MarkRepository(SchoolAppContext context) : base(context)
        {
        }
    }
}
