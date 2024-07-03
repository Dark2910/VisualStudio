using System;

namespace JuegoConNumeros
{
    class Program
    {
        static void Numeros(int a)
        {
            long v;
            v = 0;

            for (int i = 0; i < a; i++)
            {
                v = v + (long)Math.Pow(10, i);

                Console.WriteLine(v + " * " + v + " = " + v*v);
            }
        }
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Juego con numeros\nIngresa un limite");
            a = int.Parse(Console.ReadLine());
            Numeros(a);
            Console.ReadLine();
        }
    }
}
