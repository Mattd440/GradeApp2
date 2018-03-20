using System;
using GradeProject.Models;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace GradeProject.Controllers
{
    public  static class StudentController
    {
        private static GradeContext context = new GradeContext();
        public static void GetStudentMenu()
        {
            bool isInValidEntry = true;

            while (isInValidEntry)
            {
                Console.WriteLine("Choose A Student To Grade");
                Console.WriteLine("Enter 1 To ADD A New Student ");
                Console.WriteLine("Enter 2 To Use An Existing Student");
                Console.WriteLine("Enter 3 To Show All Entered Students");
                Console.WriteLine("Enter 4 To Exit");
                try
                {
                    var entry = int.Parse(Console.ReadLine());
                    if (entry > 4 || entry < 1)
                    {
                        continue;
                    }
                    else
                    {
                        isInValidEntry = false;
                    }

                    if (entry == 1)
                    {
                        // call method to get new student
                        EnterNewStudent();
                        break;
                    }
                    else if (entry == 2)
                    {
                        FindStudent();
                        break;
                    }
                    else if (entry == 3)
                    {
                        // Display All Students
                        GetAllStudents();
                        break;
                    }
                    else
                    {
                        //EXIT THE WHOLE PROGRAM
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }


            // gets new student
            private static Student EnterNewStudent()
            {
                Console.WriteLine("Enter First Name");
                var first = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                var last = Console.ReadLine();
                Console.WriteLine("Enter Major");
                var major = Console.ReadLine();

                var student = new Student(first, last, major);
                context.Students.Add(student);
                context.SaveChanges();

                return student;
            }
        // checks if the student id entered is valid
        public static bool StudentExists(int id)
        {
            var student = GetStudentById(id);

            if(student == null)
            {
                return false;
            }else{
                return true;
            }
        }

            // Look up student
        private static Student FindStudent()
        {
            

            try
            {
                Console.WriteLine("Enter The Students ID");
                var id = int.Parse(Console.ReadLine());
                var student = GetStudentById(id);
                //Console.WriteLine(student.First().FirstName);
                return student;
               
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
                              
        }



        public static Student GetStudentById(int id)
        {
            var student = from s in context.Students
                          where s.Id == id
                          select s;
            return student.FirstOrDefault();
        }
            
            

        // Get list of all students
        private static void GetAllStudents()
        {
            var students = context.Students.ToList();
            //Console.WriteLine(students);

            foreach(var std in students)
            {
                Console.WriteLine(std.ToString());
            }
        }
        }
    }

