using System;
using System.Collections.Generic;

namespace GeneradorHorario_NumerosPseudoaleatorios
{
    class Program
    {
        static void Horario(int j)
        {
            List<double> guardar = new List<double>();
            Random random = new Random();
            String horas, minutos, segundos, valor;
            double aleatorio;
            int contador;
            bool aceptar;

            contador = guardar.Count;

            do
            {
                horas = random.Next(0, 23).ToString();
                minutos = random.Next(0, 59).ToString();
                segundos = random.Next(0, 59).ToString();

                if (horas.Length == 1)
                {
                    horas = "0" + horas;
                }
                if (minutos.Length == 1)
                {
                    minutos = "0" + minutos;
                }
                if (segundos.Length == 1)
                {
                    segundos = "0" + segundos;
                }

                valor = horas + minutos + segundos;
                aleatorio = int.Parse(valor) / Math.Pow(10, valor.Length);

                aceptar = guardar.Contains(aleatorio); //Contains indica si hay o no un mismo valor en la lista

                if (aceptar == false)
                {
                    guardar.Add(aleatorio);
                    contador++;
                    Console.WriteLine("Horas ="+horas+"\nMinutos= "+minutos+"\nSegundos= "+segundos+"\nValor= "+valor+"\nAleatorio= "+guardar[contador-1]+"\n");
                }

            } while (contador < j);

            Console.WriteLine("Numeros:");

            foreach (double numeros in guardar)
            {
                Console.WriteLine(numeros);
            }
        }
        static void Main(string[] args)
        {
            int j;
            Console.WriteLine("Generador horario\n¿Cuantos numeros desea generar?");
            j = int.Parse(Console.ReadLine());
            Horario(j);
            Console.ReadLine();
        }
    }
}
