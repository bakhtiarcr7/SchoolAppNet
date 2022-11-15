using School_Management_System.Data;
using School_Management_System.Repositoies.IModelRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School_Management_System.Repositoies
{
    internal class GroupRepository:Repository<Group>,IGroupRepository
    {
        public SchoolAppContext SchoolAppContext
        {
            get { return Context as SchoolAppContext; }
        }
        public GroupRepository(SchoolAppContext context) : base(context)
        {
        }
    }
}
