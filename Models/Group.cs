using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Data;

namespace School_Management_System.Models
{
    public class Group
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }



    }
}
