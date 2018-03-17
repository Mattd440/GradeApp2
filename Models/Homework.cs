﻿using System;
using System.ComponentModel.DataAnnotations;
namespace GradeProject.Models
{
    public class Homework : Assignment
    {
        
        //string Type { get; set; }
        //Grade AssignmentGrade { get; set; }
        //string Title { get; set; }
        //Class AssignmentClass { get; set; }
        //Student Student { get; set; }
       
        public Homework(Grade grd, string title, Class cl, Student std) 
        {
            base.Type = "Homework";
            base.AssignmentGrade = grd;
            base.Title = title;
            base.AssignmentClass = cl;
            base.Student = std;
        }

    }
}
