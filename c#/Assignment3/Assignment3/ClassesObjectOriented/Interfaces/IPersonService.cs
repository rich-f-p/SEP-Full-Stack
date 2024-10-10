using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented.Interfaces
{
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary(int value);
        List<string> GetAddresses();
    }
}
