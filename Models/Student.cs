using School_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School_Management_System.Models
{
    public class Student
    {
        
    
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Mark> Marks { get; set; }
         
       
    }
}
