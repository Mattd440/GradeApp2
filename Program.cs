using System;
using GradeProject.Models;
namespace GradeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student st = Student.AddStudent();
            //Console.WriteLine(st.ToString());
            Console.WriteLine(ClassExtension.GetClassName(Class.History));
            Console.WriteLine(ClassExtension.GetClassName(Class.Math));
            //Student ss = new Student("matt", "dieder", "cset");
            //Assignment asgn = Assignment.AddAssignment(ss);
            //Console.WriteLine(asgn.ToString());
        }
    }
}
