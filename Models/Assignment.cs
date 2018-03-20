using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GradeProject.Models
{
    [NotMapped]
    public partial class Assignment
    {
       
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string AssignmentGrade { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AssignmentClass { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentId { get; set; }


        public Student Student { get; set; }

        //public Assignment(string type, Grade grade, string title, Class cl, Student std)
        //{
        //    //Id = AId;
        //    Type = type;
        //    AssignmentGrade = grade;
        //    Title = title;
        //    AssignmentClass = cl;
        //    Student = std;

        //   // AId++;
        //}




        // Grade.tostring may cause error
        //public override string ToString()
        //{
        //    return String.Format("ID: {0} , Student: {1}, {2} , Title: {3} , Class: {4} , Grade: {5}",
        //                         this.Id, this.Student.LastName, this.Student.FirstName, this.Title, this.AssignmentClass.ToString(), this.AssignmentGrade.ToString());
        //}
    }
}
