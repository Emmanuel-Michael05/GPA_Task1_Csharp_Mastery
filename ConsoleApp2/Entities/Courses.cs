using ConsoleApp2.Helpers;
using ConsoleApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Courses
    {
        public string CourseCode;
        public int CourseUnits;
        public int StudentScore;
        public Grades StudentGrade;
        public string StudentGradeRemark;
        public int WeightPoint;


        public Courses(string courseCode, int courseUnit, int studentScore)
        {
            CourseCode = courseCode;
            CourseUnits = courseUnit;
            StudentScore = studentScore;


            CourseService.CheckGrade(this, StudentScore);
            WeightPoint = CourseUnits * (int)StudentGrade;


        }
    }
}
