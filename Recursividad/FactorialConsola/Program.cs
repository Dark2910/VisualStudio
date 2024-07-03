using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursivo r = new Recursivo();

            Console.WriteLine("Escribe un número para obtener su factorial");
            Console.WriteLine(r.Factorial(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
