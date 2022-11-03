using System.Collections;
using System.Collections.Generic;

namespace School_Management_System.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }

        
        public ICollection<Teacher> Teachers { get; set; }
       
    }
}