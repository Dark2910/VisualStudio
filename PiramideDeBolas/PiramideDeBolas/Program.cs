using System;

namespace PiramideDeBolas
{
    class Program
    {
        static void CuadradosPerfectos(int a)   
        {
            int s, contador;

            s = 0;
            contador = 2;

            do
            {
                //Console.WriteLine("Cuadrado perfecto: " + Math.Pow(contador, 2));
                s = s + (int)Math.Pow(contador, 2);
                contador = contador + 1;

            } while (s + Math.Pow(contador, 2) <= a);

            Console.WriteLine("\nNumero de pisos: " + (contador - 2) + "\nBolas usadas: " + s + "\nSobrantes: "+ (a - s));

        }

        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Piramide de bolas\nIngresa el numero de bolas");
            a = int.Parse(Console.ReadLine());
            CuadradosPerfectos(a);
            Console.ReadLine();
        }
    }
}
