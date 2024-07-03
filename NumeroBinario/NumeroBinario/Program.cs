using System;

namespace NumeroBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Conversion a binario\nIngrese un numero decimal positivo: ");
            int n = int.Parse(Console.ReadLine());
            String nb = "";

            if (n < 0)
            {
                Console.WriteLine("Ingrese solo numeros positivos");
            }

            do
            {
                if (n % 2 == 0)
                {
                    nb = "0" + nb;
                }
                else
                {
                    nb = "1" + nb;
                }
                n = n / 2;

            } while (n > 0);

            Console.WriteLine(nb);
            Console.ReadLine();
        }
    }
}
