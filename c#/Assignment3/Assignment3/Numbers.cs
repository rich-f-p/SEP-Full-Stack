using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Numbers
    {
        public static int[] GenerateNumbers(int x = 10)
        {
            int[] numbers = new int[x];
            for (int i = 0;i<x;i++)
            {
                numbers[i] = i+1;
            }
            return numbers;
        }

        public static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Reverse(int[] arr)
        {
            for(int i = 0;i< arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length-1-i];
                arr[arr.Length-1-i] = temp;
            }
        }
    }
}


