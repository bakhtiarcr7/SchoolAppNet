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
            //{
            //    Dictionary<int,string> dic = new Dictionary<int,string>();
            //    dic.Add(1, "hellow1");
            //    dic.Add(2, "helllo2");
            //    foreach(KeyValuePair<int,string> kvp in dic)
            //    {

            //        Console.WriteLine(dic[kvp.Key]);
            //    }
            using (var unitOfWork = new UnitOfWork(new SchoolAppContext()))
            {


                Student st = new Student
                {
                    Firstname = "Bakhtiar",
                    LastName = "Ali",
                    Group= new Group
                    {
                        Name="V"
                    },
                    Marks = new List<Mark>
                        {
                            new Mark{
                                        Score=10,
                                        Subject=new Subject
                                        {
                                            Title="Physics",

                                        }
                            },
                            new Mark{
                                        Score=20,
                                        Subject= new Subject
                                        { Title="Chemistry"} }
                            }
                };
                //Student st2 = new Student
                //{
                //    Firstname = "Bakhtiar",
                //    LastName = "Hussain",
                //    Group= new Group(),
                //    Marks = new List<Mark>
                //        {
                //            new Mark{Score=10},
                //            new Mark{Score=20},
                //            new Mark{Score=30},
                //            new Mark{Score=90}
                //        }
                //};
              

                unitOfWork.Students.Add(st);

                //var res = unitOfWork.Students.Get(unitOfWork.Students.GetAll().Count() - 1);
                //Console.WriteLine(res.Firstname);
                //var res = unitOfWork.Students.GetStudentNHighestMarks(1, student);
                //foreach (var _ in res)
                //{
                //    Console.WriteLine($"Student_id{_.Id} and 2nd Higehest Marks is {_.Score}");
                //}

                unitOfWork.Complete();
            }

        }
        
    }
}
