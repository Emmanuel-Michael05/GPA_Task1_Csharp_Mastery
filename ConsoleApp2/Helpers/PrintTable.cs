using ConsoleApp2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Helpers
{
    public class PrintTable
    {
        public static void Print(Student student, double gpa)
        {
            

            Console.WriteLine($"| {"---------------",-15} | {"---------------",-15} | {"---------------",-15} | {"---------------",-15} | {"---------------",-15} | {"---------------",-15} |");
            Console.WriteLine($"| {"COURSE CODE",-15} | {"COURSE UNIT",-15} | {"GRADE",-15} | {"GRADE UNIT",-15} | {"WEIGHT PT.",-15} | {"REMARK",-15} |");
            Console.WriteLine($"| {"---------------",-15} | {"---------------",-15} | {"---------------",-15} | {"---------------",-15} | {"---------------",-15} | {"---------------",-15} |");
            foreach (Courses course in student.courses)
            {
                Thread.Sleep(300);
                Console.WriteLine($"| {course.CourseCode.ToUpper(),-15} | {course.CourseUnits,-15} | {course.StudentGrade,-15} | {(int)course.StudentGrade,-15} | {course.WeightPoint,-15} | {course.StudentGradeRemark,-15} |");
            }
            Console.WriteLine($"| {"---------------------------------------------------------------------",-69} | {"---------------",-15} | {"---------------",-15} |");

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine($"Total course units registered: {student.TotalCourseUnits}");
            Console.WriteLine($"Total course units passed: {student.TotalCourseUnitsPassed}");
            Console.WriteLine($"Total Weight Point: {student.TotalWeightPoints}");
            Console.WriteLine($"Your GPA: {gpa:N2}");
        }
    }
}
