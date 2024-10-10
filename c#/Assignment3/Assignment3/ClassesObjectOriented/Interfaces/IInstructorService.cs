using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented.Interfaces
{
    public interface IInstructorService : IPersonService
    {
        void SetDepartment(Department department);
        decimal AddBonusSalary();
    }
}
