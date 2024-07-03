using System;

namespace MetodoDeLosCuadrados
{
    class Program
    {
        static long Longitud(long num)
        {
            long n, contador;
            n = num;
            contador = 0;
            do
            {
                n = n / 10;
                contador += 1;

            } while (n > 0);

            return contador;
        }

        static void Cuadrados(int num, int lim)
        {
            int l, q, contador, v;
            double n, pn;

            n = num;
            
            for (int i = 0; i<lim; i++)
            {
                
                pn = Math.Pow(n, 2);
                l = (int)Longitud((int)pn);
                q = l - 4;
            
                contador = 0;
                v = 0;

                Console.WriteLine("Potencia: " + pn + "\nLongitud: " + l);

                do
                {
                    pn = pn / 10;
                    contador = contador + 1;
                } while (contador < Math.Ceiling((double)q / 2));

                contador = 0;
                n = 0;

                do
                {
                    v = (int)pn % 10;
                    pn = pn / 10;
                    n = n + v * Math.Pow(10, contador);
                    contador = contador + 1;

                } while (contador < 4);

                Console.WriteLine("Decimal: " + n / Math.Pow(10, 4));
                Console.WriteLine("Nuevo digito: " + n+"\n");
            }
        }
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Metodo de los Cuadrados\nIngresa un valor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("¿De cuantos numeros desea generar?");
            b = int.Parse(Console.ReadLine());
            Cuadrados(a, b);
            Console.ReadLine();
        }
    }
}
