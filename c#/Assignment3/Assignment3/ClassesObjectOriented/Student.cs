using Assignment3.ClassesObjectOriented.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented
{
    public class Student : Person, IStudentService
    {
        private List<Course> courses;
        private double GPA;

        public Student(DateTime birthDate, decimal salary, List<string> addresses) : base(birthDate, salary, addresses)
        {
        }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }

        public double CalculateGPA()
        {
            double GPA = 0;
            int count = 0;
            foreach (Course course in courses)
            {
                if(course.GetGrade() == "A")
                {
                    GPA += 4.0;
                    count++;
                }else if(course.GetGrade() == "B")
                {
                    GPA += 3.0;
                    count++;
                }
                else if (course.GetGrade() == "C")
                {
                    GPA += 2.0;
                    count++;
                }
                else if (course.GetGrade() == "D")
                {
                    GPA += 1.0;
                    count++;
                }
                else if (course.GetGrade() == "F")
                {
                    count++;
                }
            }
            return GPA/count;
        }
    }
}
