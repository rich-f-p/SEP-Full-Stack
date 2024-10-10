using Assignment3.ClassesObjectOriented.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented
{
    public class Instructor : Person, IInstructorService
    {
        private Department department;
        private DateTime JoinDate {  get; set; }

        public Instructor(DateTime birthDate, decimal salary, List<string> addresses) : base(birthDate, salary, addresses)
        {
        }

        public decimal AddBonusSalary()
        {
            DateTime today = DateTime.Now;
            int experience = today.Year - JoinDate.Year;
            return experience;

        }

        public void SetDepartment(Department department)
        {
            this.department = department;
        }

        public override decimal CalculateSalary(int value)
        {
            decimal total = base.CalculateSalary(value) + this.AddBonusSalary();
            return total;
        }
    }
}
