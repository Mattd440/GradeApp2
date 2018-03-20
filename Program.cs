using System;
//using System.Threading.Tasks;
using GradeProject.Models;
using GradeProject.Controllers;
namespace GradeProject
{
    class Program
    {
        public static void GetMainMenu()
        {
            bool inValidEntry = true;

            while (inValidEntry)
            {
                Console.WriteLine("Enter 1 To Enter A New Grade");
                Console.WriteLine("Enter 2 To View Homework Grades");
                Console.WriteLine("Enter 3 To View Test Grades");
                Console.WriteLine("Enter 4 To Edit Students");
                Console.WriteLine("Enter 5 To Exit ");
            
                try
                {
                    var entry = int.Parse(Console.ReadLine());

                    if(entry < 1 || entry > 5)
                    {
                        continue;
                    }else{
                        inValidEntry = false;
                    }

                    switch(entry)
                    {
                        case 1:
                            AssignmentController.AddAssignmentMenu();
                            break;
                        case 2:
                            AssignmentController.GetHomeworks();
                            break;
                        case 3:
                            AssignmentController.GetTests();
                            break;
                        case 4:
                            StudentController.GetStudentMenu();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
        static void Main(string[] args)
        {
            //Student st = Student.AddStudent();
            //Console.WriteLine(st.ToString());
            //Console.WriteLine(ClassExtension.GetClassName(Class.History));
            //Console.WriteLine(ClassExtension.GetClassName(Class.Math));
            //Student ss = new Student("matt", "dieder", "cset");
            //Assignment.AddAssignment(ss);

            //1) SHow menu to :
            // use an existing student 
            // enter new student
            // exit
            //StudentController.GetStudentMenu();

            // 2) Show menu to: 
            // enter new assignment
            // edit assignment
            // delete assignment
            // restart
            // exit


            Config.ConsoleSetup();
            bool continueEntering = true;

            while (continueEntering)
            {
                GetMainMenu();

                Console.WriteLine("");
                Console.WriteLine("Enter 1 To Continue ");
                Console.WriteLine("Press Any Key To Exit");
                try{
                    var entry = int.Parse(Console.ReadLine());

                    if(entry == 1)
                    {
                        GetMainMenu();
                    }
                    else{
                        continueEntering = false;
                    }
                }  catch(Exception ex){
                    
                }     

            }


        }
    }
}
