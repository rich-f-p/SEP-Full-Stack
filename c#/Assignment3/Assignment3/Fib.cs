using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Fib
    {
        public static int Fibonacci(int x)
        {
            if (x < 1)
            {
                return 0;
            }
            if (x <= 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }
    }
}
