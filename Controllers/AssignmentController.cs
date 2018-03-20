using System;
using System.Collections.Generic;
using System.Linq;
using GradeProject.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GradeProject.Controllers
{
    public static class AssignmentController
    {
        private static GradeContext context = new GradeContext();
        public static void GetHomeworks()
        {
            var hw = context.Homeworks.ToArray();
            Console.WriteLine(hw);
            foreach(var h in hw)
            {
                var student = StudentController.GetStudentById(h.StudentId);

                Console.WriteLine(GetString(h, student));
            }
        }

        public static void GetTests()
        {
            var tests = context.Tests.ToList(); 

            foreach(var t in tests)
            {
                var student = StudentController.GetStudentById(t.StudentId);

                Console.WriteLine(GetString(t, student));
            }
        }

         private static string GetString(Assignment asg, Student s)
         {
            return String.Format(
            "ID: {0} , Student: {1}, {2} , Title: {3} , Class: {4} , Grade: {5}",
                asg.Id, s.LastName, s.FirstName, asg.Title, asg.AssignmentClass, asg.AssignmentGrade);
         }

       

        public static void AddAssignmentMenu(){
            bool invalid = true;

            while (invalid)
            {
                Console.WriteLine("Enter the Students Id");
                try
                {
                    var entry = int.Parse(Console.ReadLine());
                    bool exists = StudentController.StudentExists(entry);

                    if (exists)
                    {
                        invalid = false;

                        var student = StudentController.GetStudentById(entry);

                        AddAssignment(student);
                    }
                    else{
                        Console.WriteLine("Invalid Student Id Please Try Again");
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        private static void AddAssignment(Student std)
        {
            //bool continueEntering = true;
            bool invalidType = true;
            bool invalidClass = true;
            bool invalidGrade = true;
            int type = 1;
            //string asgType ;
            int cls;
            Grade grade = Grade.None;
            int grd;
            string title;
            Class classType = Class.None;


                while (invalidType)
                {
                    Console.WriteLine("Enter 1 to enter A new Homework Assignment ");
                    Console.WriteLine("Enter 2 to enter A new Test Assignment");
                    try
                    {
                        type = int.Parse(Console.ReadLine());
                        if (type == 1 || type == 2)
                        {
                            invalidType = false;
                            //if (type == 1)
                            //{
                            //    asgType = "Homework";
                            //}

                            //if (type == 2)
                            //{
                            //    asgType = "Test";
                            //}
                        }
                        else
                        {
                            Console.WriteLine("Invalid Entry");
                            continue;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.WriteLine("Enter Assignment Title");
                title = Console.ReadLine();

                while (invalidClass)
                {
                    Console.WriteLine("Enter 1 To Enter A Math Assignment ");
                    Console.WriteLine("Enter 2 To Enter A English Assignment ");
                    Console.WriteLine("Enter 3 To Enter A Science Assignment ");
                    Console.WriteLine("Enter 4 To Enter A Computer Science Assignment ");
                    Console.WriteLine("Enter 5 To Enter A History Assignment ");
                    try
                    {
                        cls = int.Parse(Console.ReadLine());

                        // controls whether the loops continues or stops
                        if (cls > 5 || cls < 1)
                        {
                            Console.WriteLine("Invalid Entry ");
                            continue;
                        }
                        else
                        {
                            invalidClass = false;
                        }

                        switch (cls)
                        {
                            case 1:
                                classType = Class.Math;
                                break;
                            case 2:
                                classType = Class.English;
                                break;
                            case 3:
                                classType = Class.Science;
                                break;
                            case 4:
                                classType = Class.ComputerScience;
                                break;
                            case 5:
                                classType = Class.History;
                                break;
                            default:
                                invalidClass = true;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                while (invalidGrade)
                {
                    Console.WriteLine("Enter 1 to Give Grade of 'A' ");
                    Console.WriteLine("Enter 2 to Give Grade of 'B' ");
                    Console.WriteLine("Enter 3 to Give Grade of 'C' ");
                    Console.WriteLine("Enter 4 to Give Grade of 'D' ");
                    Console.WriteLine("Enter 5 to Give Grade of 'F' ");
                    try
                    {
                        grd = int.Parse(Console.ReadLine());

                        if (grd > 5 || grd < 1)
                        {
                            Console.WriteLine("Invalid Entry");
                            continue;

                        }
                        else
                        {
                            invalidGrade = false;
                        }


                        switch (grd)
                        {
                            case 1:
                                grade = Grade.A;
                                break;
                            case 2:
                                grade = Grade.B;
                                break;
                            case 3:
                                grade = Grade.C;
                                break;
                            case 4:
                                grade = Grade.D;
                                break;
                            case 5:
                                grade = Grade.F;
                                break;
                            default:
                                grade = Grade.F;
                                invalidClass = true;
                                break;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException);
                    }

                }

                if (type == 1)
                {
                    var assignment = new Homework(grade, title, classType, std);
                    using (var context = new GradeContext())
                    {
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Students] ON");
                        context.Homeworks.Add(assignment);
                        context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Students] OFF");
                        context.SaveChanges();
                    }

                    Console.WriteLine("Assignment Added Successfully");
                }
                else
                {
                    var assignment = new Test(grade, title, classType, std);
                    using (var context = new GradeContext())
                    {
                        try
                        {
                            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Students] ON");
                            context.Tests.Add(assignment);
                            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Students] OFF");
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.InnerException);
                        }
                    }
                    Console.WriteLine("Assignment Added Successfully");
                }

                Console.WriteLine("");
                Console.WriteLine("Enter 1 To Add Another Grade ");
                Console.WriteLine("Enter Any Key To Exit ");

                
                try
                {
                    var input = int.Parse(Console.ReadLine());

                    if (input == 1)
                    {
                        AddAssignmentMenu();
                    }
                   
                }catch(Exception ex)
                {
                    
                }


            }


        
        
        }
    }

