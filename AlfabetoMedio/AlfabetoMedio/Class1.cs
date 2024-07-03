using System;
using System.Collections.Generic;
using System.Text;

namespace AlfabetoMedio
{
    class Class1
    {
        private static char[] alphabet1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', ' ' };
        private static char[] alphabet2 = { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
        private int i, contador;
        private char lyrics;
        private String word2;

        public Class1()
        {
            this.i = 0;
            this.contador = 0;
            this.lyrics = ' ';
            this.word2 = "";
        }

        public void Letra(String word)
        {
            for (i = 0; i <= word.Length-1; i++)
            {
                lyrics = word[i];
                Buscar(lyrics);
            }
            Imprimir();
        }

        public void Buscar(char lyrics)
        {
            do 
            {
                if (alphabet1[contador].Equals(lyrics))
                {
                    word2 += alphabet2[contador];
                    break;
                }
                contador++;
            } while (contador < alphabet1.Length);
            contador = 0;

            do
            {
                if (alphabet2[contador].Equals(lyrics))
                {
                    word2 += alphabet1[contador];
                    break;
                }
                contador++;
            } while (contador < alphabet2.Length);
            contador = 0;
        }   

        public void Imprimir()
        {
            Console.WriteLine(word2);
        }
    }
}
