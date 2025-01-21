using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Student
    {
        public string [] studentName { get; set; }
        public int studentId { get; set; }
        public List<Courses> courses { get; set; } = new();
        public int TotalCourseUnits { get; set; } = 0;
        public int TotalCourseUnitsPassed { get; set; } = 0;
        public int TotalWeightPoints { get; set; } = 0;

        public Student(string [] studentName, int studentId)
        {
            this.studentName = studentName;
            this.studentId = studentId;
        }
    }
    
}
