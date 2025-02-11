﻿using ConsoleApp2.Entities;
using ConsoleApp2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Services
{
    public class CourseService
    {
        public static void CheckGrade(Courses course, int score)
        {
            if (score > 69)
            {
                course.StudentGrade = Grades.A;
                course.StudentGradeRemark = "Excellent";
            }
            else if (score > 59)
            {
                course.StudentGrade = Grades.B;
                course.StudentGradeRemark = "Very Good";
            }
            else if (score > 49)
            {
                course.StudentGrade = Grades.C;
                course.StudentGradeRemark = "Good";
            }
            else if (score > 44)
            {
                course.StudentGrade = Grades.D;
                course.StudentGradeRemark = "Fair";
            }
            else if (score > 39)
            {
                course.StudentGrade = Grades.E;
                course.StudentGradeRemark = "Pass";
            }
            else
            {
                course.StudentGrade = Grades.F;
                course.StudentGradeRemark = "Fail";
            }
        }
    }
}
