using System;

namespace NumeroMalvado
{
    class Program
    {
        static string ConvertirABinario(int num)
        {
            int n = num;
            String nb = "";

            if (n < 0)
            {
                return "0";
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

            return nb;
        }
        static int Malvado(int num)
        {
            int n, c, m;
            n = num;
            c = 0;
            m = 0;

            if (n <= 0)
            {
                return 0;
            }
            do
            {
                if (n % 2 != 0)
                {
                    c = c + 1;
                }

                n = n / 2;

            } while (n > 0);

            m = c % 2;

            if (m == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void MalvadoLista(int i, int f)
        {
            Console.WriteLine("Lista de numeros malvados");
            do
            {
                if (Malvado(i) == 1)
                {
                    Console.WriteLine(i + " = " + ConvertirABinario(i));
                }
                i++;
            } while (i<=f);
        }

        static void Main(string[] args)
        {
            int i, f;

            //Console.Write("Numero Binario\nIngresa un numero decimal positivo\n");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine(ConvertirABinario(i));
            //Console.ReadLine();

            //Console.WriteLine("Numero Malvado\nIngresa un numero:");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine(Malvado(i));
            //Console.ReadLine();

            Console.Write("Numeros Malvados\nIngresa tu rango inicial\n");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu rango final:");
            f = int.Parse(Console.ReadLine());
            MalvadoLista(i, f);
            Console.ReadLine();
        }
    }
}
