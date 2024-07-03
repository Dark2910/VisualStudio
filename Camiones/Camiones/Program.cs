using System;

namespace Camiones
{
    class Program
    {
        static void LaTortuga(int a, int b)
        {
            int n, d, v, contador;

            n = 0;
            d = 0;
            v = 0;
            contador = 0;

            for(int i = a; i <= b; i++)
            {
                n = (int)Math.Pow(i, 2);
                do
                {  
                    d = n % 10;
                    n = n / 10;
                    v = v + d * (int)Math.Pow(10,contador);
                    contador = contador + 1;

                    if (v == i)
                    {
                        Console.WriteLine("\n"+i + "^2 = " + Math.Pow(i, 2) +
                            "\n"+ Math.Pow(i, 2) + " termina con el numero: " + v);
                        break;
                    }
                    
                } while (n > 0);
                contador = 0;
                v = 0;  
            }
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Camiones la tortuga\nIngresa un rango\nValor inicial:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor final:");
            b = int.Parse(Console.ReadLine());
            LaTortuga(a,b);
            Console.ReadLine();
        }
    }
}
