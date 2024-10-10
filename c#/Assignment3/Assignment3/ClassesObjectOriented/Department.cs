using Assignment3.ClassesObjectOriented.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented
{
    public class Department : IDepartmentService
    {
        private Instructor head;
        private decimal budget;
        private List<Course> courses;

        public void AssignHead(Instructor instructor)
        {
            this.head = instructor;
        }

        public decimal GetBudget()
        {
            return this.budget;
        }

        public void SetBudget(decimal budget)
        {
            this.budget = budget;
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public void AddCouses(Course course)
        {
            courses.Add(course);
        }
    }
}
