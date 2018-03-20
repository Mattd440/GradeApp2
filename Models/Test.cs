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
       public Test(){}

        public Test(Grade grd, string title, Class cl, Student std)
        {
            //base.Id = 10;
            base.Type = "Test";
            base.AssignmentGrade = GradeExtension.GetGradeString(grd);
            base.Title = title;
            base.AssignmentClass = ClassExtension.GetClassName(cl);
            //base.Student = std;
            base.StudentId = std.Id;
        }


    }
}
