using System;
namespace GradeProject.Models
{
    public enum Class
    {
        Math = 0,
        English,
        Science,
        ComputerScience,
        History,
        None
    }


    public static class ClassExtension
    {
        public static string GetClassName(Class cls)
        {
            String className = "class";
            switch (cls)
            {
                case Class.Math: 
                    className = "Math";
                    break;
                case Class.English: 
                    className = "English";
                    break;
                case Class.Science: 
                    className = "Science";
                    break;
                case Class.ComputerScience: 
                    className = "ComputerScience";
                    break;
                case Class.History: 
                    className = "History";
                    break;
                default:
                    className = "Error";
                    break;
            }
            return className;
        }
    }
}

