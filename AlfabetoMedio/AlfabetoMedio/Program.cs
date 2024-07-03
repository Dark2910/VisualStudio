using System;

namespace AlfabetoMedio
{
    class Program
    {
       public static void Main(string[] args)
        {
            String word, answer;

            do {
                Console.Clear();

                Console.WriteLine("Alfabeto medio (Ejemplo pata encriptar)\nAnota una oracion");
                word = Console.ReadLine();

                Class1 w = new Class1();
                w.Letra(word);

                Console.WriteLine("¿Desea salir? Y / N");
                answer = Console.ReadLine().ToLower();

            } while (answer != "y");

        }
    }
}
