using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocker
{
    // dos puntos : significa heredar
    class Pocker : Aleatorios
    {
        private int rango;
        private List<int> aleatorios = new List<int>();
        public Pocker(int rango)
        {
            this.rango = rango;
        }
        public List<List<double>> Calcular_EI(List<List<double>> tabla)
        {
            List<double> T = new List<double>();
            foreach (var X in Cartas)
            {
                T.Add(X * rango);
            }
            tabla.Add(T);
            return tabla;
        }
        public List<List<double>> Calcular_OI(List<List<double>> tabla) // llamada de OI
        {
            return Calcula_oi(Conversion(), tabla);
        }
        private List<List<double>> Calcula_oi(List<int> aleatorios, List<List<double>> tabla)
        {
            List<double> Y = new List<double>();
            for (int i = 0; i < 11; i++)
                Y.Add(Conteo(aleatorios, i));
            tabla.Add(Y);
            return tabla;
        }
        public List<List<double>> Calcular_ei_oi(List<List<double>> tabla)
        {
            List<double> A = new List<double>();
            for (int i = 0; i < 7; i++)
                A.Add(Math.Truncate(tabla[0][i] - tabla[1][i] * 100) / 100);
            tabla.Add(A);
            return tabla;
        }
        public List<List<double>> Elevacion_Cuadrado(List<List<double>> tabla)
        {
            List<double> A = new List<double>();
            for (int i = 0; i < 7; i++)
                A.Add(Math.Truncate(Math.Pow(tabla[2][i], 2) * 100) / 100);
            tabla.Add(A);
            return tabla;
        }
        private int Conteo(List<int> aleatorios, int bandera)
        {
            int contador = 0;
            foreach (int X in aleatorios)
            {
                if (Compa(X) == bandera)
                    contador += 1;
            }
            return contador;
        }
        private List<int> Conversion()
        {
            foreach (var X in T)
            {
                aleatorios.Add(Convert.ToInt32(X * 100000));
            }
            return aleatorios;
        }
        // VER QUE TIPOS DE CARTAS SON
        private int Compa(int numero)
        {
            int contador = 0;
            int residuo = numero % 10;
            numero = numero / 10;
            for (; numero > 0; numero = numero / 10)
            {
                contador += Conteo(numero, residuo);
                residuo = numero % 10;
            }
            return contador;
        }
        private int Conteo(int numero, int digito)
        {
            int contador = 0;
            for (; numero > 0; numero = numero / 10)
            {
                if (numero % 10 == digito)
                    contador += 1;
            }
            return contador;
        }
        public void Verificar()
        {
            foreach (var X in aleatorios)
            {
                if (Compa(X) == 0)
                    Console.WriteLine("ES NON -> {0}", X);
                else if (Compa(X) == 1)
                    Console.WriteLine("ES PAR -> {0}", X);
                else if (Compa(X) == 2)
                    Console.WriteLine(" DosPares -> {0}", X);
                else if (Compa(X) == 3)
                    Console.WriteLine("TERCIA -> {0}", X);
                else if (Compa(X) == 4)
                    Console.WriteLine("FULL-> {0}", X);
                else if (Compa(X) == 6)
                    Console.WriteLine("POCKER-> {0}", X);
                else if (Compa(X) == 10)
                    Console.WriteLine("ESTOY AQUI->{0}", X);
            }
        }
    }
}
