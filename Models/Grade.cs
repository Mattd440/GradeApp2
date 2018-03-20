using System;
namespace GradeProject.Models
{
    public enum Grade
    {
        A = 0 , B, C, D, F, None
    }

    public static class GradeExtension
    {
        public static string GetGradeString(Grade grade)
        {
            string gradeLetter;
            switch(grade)
            {
                case Grade.A:
                    gradeLetter = "A";
                    break;
                case Grade.B:
                    gradeLetter = "B";
                    break;
                case Grade.C:
                    gradeLetter = "C";
                    break;
                case Grade.D:
                    gradeLetter = "D";
                    break;
                case Grade.F:
                    gradeLetter = "F";
                    break;
                default:
                    gradeLetter = "";
                    break;
            }
            return gradeLetter;
        }
    }
}
