﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented.Interfaces
{
    public interface IStudentService : IPersonService
    {
        void AddCourse(Course course);
        double CalculateGPA();
    }
}
