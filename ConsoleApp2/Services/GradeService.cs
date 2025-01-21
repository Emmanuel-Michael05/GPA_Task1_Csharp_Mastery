using ConsoleApp2.Entities;
using ConsoleApp2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class GradeService
    {
        public static void Calculate(Student student)
        {
            double gpa = (double)student.TotalWeightPoints / student.TotalCourseUnits;

            PrintTable.Print(student, gpa);
        }
    }
}
