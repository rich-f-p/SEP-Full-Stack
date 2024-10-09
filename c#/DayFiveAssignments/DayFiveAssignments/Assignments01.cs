using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFiveAssignments
{
    public class Assignments01
    {
        public void PlayConsole() { 
        // Playing with the console app
        Console.WriteLine("Hello what is your favorite color?");
        string? color;
        color = Console.ReadLine();
        Console.WriteLine("What is your astrology sign?");
        string? astr;
        astr = Console.ReadLine();
        Console.WriteLine($"what is your street address number?");
        string? address;
        address = Console.ReadLine();
        Console.WriteLine($"Your hacker name is {color}{astr}{address}");
        }

        public void SizeOfTypes()
        {
            //Practice number sizes and ranges:
            //1.
            //sbyte
            string sbyteMinMax = string.Format("sbyte - Min: {0}, Max: {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(sbyteMinMax);
            //byte
            string byteMinMax = string.Format("byte - Min: {0}, Max: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine(byteMinMax);
            //short
            string shortMinMax = string.Format("short - Min: {0}, Max: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine(shortMinMax);
            //ushort
            string ushortMinMax = string.Format("ushort - Min: {0}, Max: {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(ushortMinMax);
            //int
            string intMinMax = string.Format("int - Min: {0}, Max: {1}", int.MinValue, int.MaxValue);
            Console.WriteLine(intMinMax);
            //uint
            string uintMinMax = string.Format("uint - Min: {0}, Max: {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine(uintMinMax);
            //long
            string longMinMax = string.Format("long - Min: {0}, Max: {1}", long.MinValue, long.MaxValue);
            Console.WriteLine(longMinMax);
            //ulong
            string ulongMinMax = string.Format("ulong - Min: {0}, Max: {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine(ulongMinMax);
            //float
            string floatMinMax = string.Format("float - Min: {0}, Max: {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(floatMinMax);
            //double
            string doubleMinMax = string.Format("double - Min: {0}, Max: {1}", double.MinValue, double.MaxValue);
            Console.WriteLine(doubleMinMax);
            //decimal
            string decimalMinMax = string.Format("decimal - Min: {0}, Max: {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine(decimalMinMax);
        }

        public void CenturiesConversion()
        {
            // 2. enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.
            Console.WriteLine("Enter an integer number of centuries");
            byte centuries;
            centuries = byte.Parse(Console.ReadLine());
            ushort Years = (ushort)(100 * centuries);
            uint Days = (uint)(365.24219 * Years);
            ulong Hours = 24 * Days;
            ulong Minutes = 60 * Hours;
            ulong Seconds = 60 * Minutes;
            ulong Milliseconds = 1000 * Seconds;
            ulong Microseconds = 1000 * Milliseconds;
            ulong Nanoseconds = 1000 * Microseconds;

            Console.WriteLine($"{centuries} centuries = {Years} years = {Days} days = {Hours} hours = {Minutes} minutes = {Seconds} seconds = {Milliseconds} miliseconds = {Microseconds} microseconds = {Nanoseconds} nanseconds");
        }

        public void FizzBuzz()
        {
            //Practice Loops and Operators
            //1.
            //FizzBuzz Chapter03 Exercise03
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                string divisibleByThree = "";
                string divisibleByFive = "";
                if (i % 3 == 0)
                {
                    divisibleByThree = "fizz";
                }
                if (i % 5 == 0)
                {
                    divisibleByFive = "buzz";
                }
                if (divisibleByThree != "" || divisibleByFive != "")
                {
                    Console.WriteLine(divisibleByThree + divisibleByFive);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            //What will happen if this code executes?
            //int max = 500;
            //for (byte i = 0; i < max; i++)
            //{
            //    WriteLine(i);
            //}
            // byte has a max value of only 255, which int max=500 exceeds. conflicting logic in for loop where byte never reaches 500 to exit the loop.
            // Writeline does not exist in the current context. This can be fixed by performing 'Console.WriteLine(i);'
        }

        public void GenerateOneToThree()
        {
            //generates a random number between 1 and 3 and asks the user to guess what the number is.
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please enter a number from 1 to 3?");
            int numInput = int.Parse(Console.ReadLine());
            if (numInput > 3 || numInput < 1)
            {
                Console.WriteLine("Your entered number is out of range");
            }
            else if (numInput == correctNumber)
            {
                Console.WriteLine($"Correct: it was {correctNumber}");
            }
            else if (numInput > correctNumber)
            {
                Console.WriteLine($"you guessed high. It was {correctNumber}");
            }
            else if (numInput < correctNumber)
            {
                Console.WriteLine($"you guessed low. It was {correctNumber}");
            }
        }

        public void PrintPyramid()
        {
            //2.Print - a - Pyramid: print a pyramid that matches the example provided in assignment.
            int space = 4;
            for (int i = 0; i < 5; i++)
            {
                string printStar = "";
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (k < space || k >= 9 - space)
                        {
                            printStar += " ";
                        }
                        else
                        {
                            printStar += $"*";
                        }
                    }
                    space = space - 1;
                }
                Console.WriteLine(printStar);
            }
        }

        public void NumberGuessing()
        {
            //3.generates a random number between 1 and 3 and asks the user to guess what the number is.
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please enter a number from 1 to 3?");
            int numInput = int.Parse(Console.ReadLine());
            if (numInput > 3 || numInput < 1)
            {
                Console.WriteLine("Your entered number is out of range");
            }
            else if (numInput == correctNumber)
            {
                Console.WriteLine($"Correct: it was {correctNumber}");
            }
            else if (numInput > correctNumber)
            {
                Console.WriteLine($"you guessed high. It was {correctNumber}");
            }
            else if (numInput < correctNumber)
            {
                Console.WriteLine($"you guessed low. It was {correctNumber}");
            }
        }

        public void BirthDateCalculations()
        {
            //4. program that defines a variable representing a birth date and calculates how many days old the person with that birth date is currently
            DateTime BirthDate = new DateTime(2000, 12, 31);
            DateTime Today = new DateTime();
            Today = DateTime.Now;
            TimeSpan Difference = Today - BirthDate;
            Console.WriteLine($"Difference in days: {Difference.Days}");

            int daysToNextAnniversary = 10000 - (Difference.Days % 10000);
            Console.WriteLine($"10,000 day anniversary is in: {daysToNextAnniversary} days");
            DateTime Extra = BirthDate.AddYears(27);
            Console.WriteLine($"10,000 day anniversary is on: {Extra}");
        }

        public void GreetingOfDay()
        {
            //5.Greet the user using the appropriate greeting for the time of day.
            int currentTime = DateTime.Now.Hour;
            if (currentTime < 11 && currentTime > 3)
            {
                Console.WriteLine("Good Morning");
            }
            if (currentTime < 15 && currentTime > 11)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (currentTime < 19 && currentTime > 15)
            {
                Console.WriteLine("Good Evening");
            }
            if (currentTime < 23 && currentTime > 19)
            {
                Console.WriteLine("Good Night");
            }
            if (currentTime < 3)
            {
                Console.WriteLine("Good Night");
            }
        }

        public void CountingToTwentyFour ()
        {
            //6. Program that prints the result of counting up to 24 using four different increments(1s,2s,3s,4s).
            int increment = 1;
            for (int i = 1; i <= 4; i++)
            {
                string result = "";
                for (int j = 0; j <= 24; j += increment)
                {
                    if (j != 24)
                    {
                        result += $"{j},";
                    }
                    else
                    {
                        result += $"{j}";
                    }
                }
                increment++;
                Console.WriteLine(result);
            }
        }




    }
}
