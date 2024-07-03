using System;

namespace Orden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //double valor;
            //int i = 0;

            //Console.Write("¿Cúantos números deseas generar? ");
            //int parametro= int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine(valor = random.NextDouble());
            //    i++;
            //} while (i<parametro);

            //Console.ReadKey();

            Console.Write("¿Cúantos números deseas generar? ");

            Clasi s = new Clasi();
            s.Orden();
            Console.WriteLine(s); Console.ReadKey();
        }
    }
}
