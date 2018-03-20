using System;
using System.Collections.Generic;
namespace GradeProject.Models
{
    public class Student
    {
        public static int SId = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }


        public ICollection<Assignment> Assignments { get; set; }

        public Student(){ }

        public Student(string first, string last, string major)
        {
            Id = SId;
            FirstName = first;
            LastName = last;
            Major = major;

            SId++;
        }

        // should add student to database
        public static Student AddStudent()
        {
            Console.WriteLine("Enter Student First Name");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name");
            string last = Console.ReadLine();
            Console.WriteLine("Enter Student Major");
            string major = Console.ReadLine();

            Student student = new Student(first, last, major);

            //return student;
            // add to database here

            //using ( var context = new GradeContext())
            //{
            //    context.Students.Add(student);
            //    context.SaveChanges();
            //}


            return student;
        }

       
		public override string ToString()
		{
            return String.Format(
              "ID: {0} , Last Name: {1} , First Name: {2} , Major: {3} ",
                this.Id, this.LastName, this.FirstName, this.Major);
		}
	}
}
