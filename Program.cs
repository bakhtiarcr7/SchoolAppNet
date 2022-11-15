using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.IUnitOfWorkk;
using School_Management_System.Data;
using School_Management_System.Repositoies;
using School_Management_System.Models;


namespace School_Management_System
{
    internal class Program
    {
        static void Main(string[] args) {
           


            //using (var unitOfWork = new UnitOfWork(new SchoolAppContext()))
            //{
                

            //    Student st = new Student
            //    {
            //        Firstname = "Bakhtiar",
            //        LastName = "Ali",
            //        Group= new Group
            //        {
            //            Name="V"
            //        },
            //        Marks = new List<Mark>
            //            {
            //                new Mark{
            //                            Score=10,
            //                            Subject=new Subject
            //                            {
            //                                Title="Physics"

            //                            }
            //                },
            //                new Mark{
            //                            Score=20,
            //                            Subject= new Subject
            //                            { Title="Chemistry"} }
            //                }
            //    };
            //    //Student st2 = new Student
            //    //{
            //    //    Firstname = "Bakhtiar",
            //    //    LastName = "Hussain",
            //    //    Group= new Group(),
            //    //    Marks = new List<Mark>
            //    //        {
            //    //            new Mark{Score=10},
            //    //            new Mark{Score=20},
            //    //            new Mark{Score=30},
            //    //            new Mark{Score=90}
            //    //        }
            //    //};
              

            //    unitOfWork.Students.Add(st);

            //    //var res = unitOfWork.Students.Get(unitOfWork.Students.GetAll().Count() - 1);
            //    //Console.WriteLine(res.Firstname);
            //    //var res = unitOfWork.Students.GetStudentNHighestMarks(1, student);
            //    //foreach (var _ in res)
            //    //{
            //    //    Console.WriteLine($"Student_id{_.Id} and 2nd Higehest Marks is {_.Score}");
            //    //}

            //    unitOfWork.Complete();
            //}
            using (var unitOfWork = new UnitOfWork(new SchoolAppContext()))
            {
                
                Student st = new Student
                {
                    Firstname = "Hussain",
                    LastName = "Brohi",
                    Group = new Group
                    {
                        Name = "IV"
                    },
                    Marks = new List<Mark>
                        {
                            new Mark{
                                        Score=100,
                                        Subject=new Subject
                                        {
                                            Title="Psychology"

                                        }
                            },
                             new Mark{
                                        Score=70,
                                        Subject=new Subject
                                        {
                                            Title="Maths"

                                        }
                            },
                            new Mark{
                                        Score=30,
                                        Subject= new Subject
                                        { Title="English"} }
                            },
                            
                };
                //unitOfWork.Students.Add(st);
                Console.WriteLine("Get Student By Id =2 : "+unitOfWork.Students.Get(2).Firstname);
                unitOfWork.Students.GetStudentNHighestMarks(3);

                unitOfWork.Subjects.GetSubjectCount();
                unitOfWork.Subjects.isSubAvailable("Maths");
                unitOfWork.Subjects.isSubAvailable("Political Science");

                unitOfWork.Complete();

            }
        }
        
    }
}
