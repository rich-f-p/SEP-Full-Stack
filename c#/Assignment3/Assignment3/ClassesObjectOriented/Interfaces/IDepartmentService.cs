using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented.Interfaces
{
    public interface IDepartmentService
    {

        decimal GetBudget();
        void SetBudget(decimal budget);
        List<Course> GetCourses();
        void AssignHead(Instructor instructor); 
    }
}
