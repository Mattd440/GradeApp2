using System;
using System.ComponentModel.DataAnnotations;
namespace GradeProject.Models
{
    public class Test : Assignment
    {
        //string Type { get; set; }
        //Grade AssignmentGrade { get; set; }
        //string Title { get; set; }
        //Class AssignmentClass { get; set; }
        //Student Student { get; set; }
       
        public Test(Grade grd, string title, Class cl, Student std)
        {
            base.Type = "Test";
            base.AssignmentGrade = grd;
            base.Title = title;
            base.AssignmentClass = cl;
            base.Student = std;
        }
    }
}
