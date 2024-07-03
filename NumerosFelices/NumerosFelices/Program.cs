using System;

namespace NumerosFelices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =0, d = 0, s = 0;
            Console.WriteLine("Numeros felices\nIngresa un digito: ");
            n=int.Parse(Console.ReadLine());

            do
            {
                s = 0;
                do
                {
                    d = n % 10;
                    n = n / 10;
                    s = s + (d * d);

                    Console.WriteLine("d= "+d);
                    Console.WriteLine("s= "+s);

                } while (n > 0);
                n = s;
            } while (n != 89 && n != 1);

            if (s == 1){
                Console.WriteLine("Es un numero feliz");
            }
            else
            {
                Console.WriteLine("No es un numero feliz");
            }
            Console.ReadLine();
        }
    }
}
