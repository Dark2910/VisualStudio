using System;

namespace CamisetasDeFutbol
{
    class Program
    {
        static int Elimina (int num, int b)
        {
            int n, p, contador;
            double v;

            n = num;
            contador = 0;
            v = 0;
            p = 0;

            do
            {
                if (p == 0 && n % 10 == b)
                {
                    p = 1;
                }
                else
                {
                    v = v + (n % 10) * Math.Pow(10, contador);
                    contador = contador + 1;
                }

                n = n / 10;

            } while (n != 0);

            return (int)v;
        }
        static int Eliminar(int a, int b)
        {
            int n, m;

            n = a;
            m = b;

            do
            {
                n = Elimina(n, m % 10);
                m = m / 10;

            } while (m != 0); 

            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n;
            }
        }
        static void Machetero(int num, int den)
        {
            int nn, nd;

            nn = Eliminar(num, den);
            nd = Eliminar(den, num);

            Console.WriteLine("\n"+num+"/"+den+" -> "+nn+"/"+nd);

        }
        static void Camisetas(int s, int e)
        {
            int vo, vt, d, contador;

            vo = 0;
            vt = 0;
            d = 0;
            contador = 0;

            for (int i = s; i <= e; i++)
            {
                for (int j = s; j <= e; j++)
                {
                    if (i != j)
                    {
                        vo = (int)Math.Pow(i + j, 2);
                        do
                        {
                            d = vo % 10;
                            vo = vo / 10;
                            vt = vt + d * (int)Math.Pow(10, contador);
                            contador = contador + 1;

                            if (vo == i)
                            {
                                break;
                            }

                        } while (vo > 0);

                        if (vo == i && vt == j)
                        {
                            Console.WriteLine("\n" + i + "+" + j + "=" + (i + j) + "\nPonecia: " +
                                Math.Pow(i + j, 2) + "\nCamiseta: " + i + "\nCamiseta: " + j);
                        }
                        contador = 0;
                        vt = 0;
                    }
                }
            }
            Console.WriteLine("\nFin de la lista");
        }
        static void Main(string[] args)
        {
            int a, b;

            //Console.WriteLine("Elimina\nIngrea un valor:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor a quitar:");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Elimina(a, b));
            //Console.ReadLine();

            //Console.WriteLine("Eliminar\nIngrea un valor:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa otra valor:");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine(Eliminar(a, b));
            //Console.ReadLine();

            //Console.WriteLine("Machetero\nValor del numerador:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor del denominador:");
            //b = int.Parse(Console.ReadLine());
            //Machetero(a, b);
            //Console.ReadLine();

            Console.WriteLine("Camisetas de futbol\nValor inicial:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor final:");
            b = int.Parse(Console.ReadLine());
            Camisetas(a, b);
            Console.ReadLine();
        }
    }
}
