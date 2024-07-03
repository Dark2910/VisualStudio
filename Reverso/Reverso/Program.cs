using System;

namespace Reverso
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
            char[] tebahpla = { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a', ' ' };

            String word1, word2;
            char lyrics;
            int i, j;

            Console.WriteLine("Reverso\nEscribe una oracion");
            word1 = Console.ReadLine();
            word2 = "";

            for(i = 0; i <= word1.Length-1; i++)
            {
                lyrics = word1[i]; //Obtenemos cada caracter de la oracion

                for(j = 0; j <= alphabet.Length; j++)
                {
                    if (alphabet[j].Equals(lyrics))
                    {
                        break;
                    }
                }
                word2 += tebahpla[j];
            }
            Console.WriteLine(word2);
            Console.ReadLine();
        }   
    }
}
