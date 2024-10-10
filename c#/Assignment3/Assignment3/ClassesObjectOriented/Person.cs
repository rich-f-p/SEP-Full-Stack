using Assignment3.ClassesObjectOriented.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ClassesObjectOriented
{
    public class Person : IPersonService
    {
        private DateTime birthDate {  get; set; }
        private decimal salary {  get; set; }
        private List<string> addresses { get; set; }

        public Person(DateTime birthDate,decimal salary, List<string> addresses)
        {
            this.birthDate = birthDate;
            this.salary = salary;
            this.addresses = addresses;
        }

        public int CalculateAge(DateTime birthDate)
        {
            DateTime todayYear = DateTime.Now;
            int age = todayYear.Year - birthDate.Year;
            if (todayYear < birthDate) { age -= 1; }
            return age;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - this.birthDate.Year;
            if (today.Day < this.birthDate.Day) { age = age-1; }
            return age;
        }


        public virtual decimal CalculateSalary(int value)
        {
            return  value * salary;
        }

        public List<string> GetAddresses()
        {
            return addresses;
        }

    }
}
