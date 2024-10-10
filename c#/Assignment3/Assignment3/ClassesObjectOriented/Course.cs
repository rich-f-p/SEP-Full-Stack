using Assignment3.ClassesObjectOriented.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented
{
    public class Course : ICourseService
    {
        private List<Student> students;
        private string Grade;

        public List<Student> GetStudents()
        {
            return this.students;
        }
        public string GetGrade()
        {
            return this.Grade;
        }

        public void SetGrade(string Grade)
        {
            this.Grade = Grade;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
