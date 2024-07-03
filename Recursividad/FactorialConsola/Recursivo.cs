using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialConsola
{
    class Recursivo
    {
        public int Factorial(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Su factorial es: ");
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
                //3 * 2 * 1 * 1 = 6
            }
        }
    }
}
