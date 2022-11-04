using School_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Core.Objects;
using System.Security.Cryptography;

namespace School_Management_System.Repositoies
{
    internal class StudentRepository : Repository<Student>, IStudentRepository
    {
        public SchoolAppContext SchoolAppContext
        {
            get { return Context as SchoolAppContext; }
        }
        public StudentRepository(SchoolAppContext context) : base(context)
        {
        }

        public IEnumerable<Mark> GetStudentNHighestMarks(int count)
        {
            try
            {
                //var query = SchoolAppContext.Marks
                //        .GroupBy(b => b.Subject_Id)
                //        .Select(e => new
                //        {
                //            Id = e.Key,
                //            Score = e.OrderByDescending(f => f.Score).Select(f => f.Score).Distinct().Skip(count-1).First()

                //        }).ToList();
                //var temp= SchoolAppContext.Students
                //IEnumerable<Mark> query = SchoolAppContext.Marks
                //                            .GroupBy(e => e.Score)
                //                            .OrderByDescending(g => g.Key)
                //                            .Skip(count - 1).Select(a => new {a.})
                //                            .First();
                //IEnumerable<Mark> query = SchoolAppContext.Marks
                //                            .GroupBy(e => e.Score)
                //                            .OrderByDescending(g => g.Key)
                //                            .Skip(count - 1).Select(a => new { Student_ })
                //                            .First();
                //IEnumerable<Mark> query = SchoolAppContext.Students
                //                        .Select(student => new 
                //                        {
                //                            Name = student.Firstname + " " + student.LastName,
                //                            Student_Id = student.Id,

                //                        });


                //return query;
                //var studentMarks =SchoolAppContext.Students.Include(u => u.Marks).ToList();
                var highm = from p in SchoolAppContext.Marks
                            group p by p.StudentId into sgroup
                            select new { marks=}
                            
                foreach (var obj in highm)
                {
                    Console.WriteLine($"Student ID= {obj.Id}");
                }

                return (IEnumerable<Mark>)highm;


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message+" "+e.StackTrace);
            }
            return null;
            
            //return SchoolAppContext.Students.OrderByDescending(s => s.Marks).Take(count).ToList();
        }

        public IEnumerable<Student> GetStudentLowestMarks(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
