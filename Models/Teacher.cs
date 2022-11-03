using System.Collections;
using System.Collections.Generic;

namespace School_Management_System.Models
{
    public class Teacher
    {
       
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Group> Groups { get; set; }

    }
}