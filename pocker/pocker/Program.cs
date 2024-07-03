using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] evento = { "NON", "PAR", "2PARES", "TERCIA", "FULL", "POCKER", "QUINTILLA" };
            List<List<double>> Tabla = new List<List<double>>();
            int rango = 0;
            Console.Write("Dame un rango: ");
            rango = int.Parse(Console.ReadLine());
            Pocker ob = new Pocker(rango);
            ob.Generar_Valores(rango);
            ob.Calcular_EI(Tabla);
            ob.Calcular_OI(Tabla);
            ob.Calcular_ei_oi(Tabla);
            ob.Elevacion_Cuadrado(Tabla);
            ob.Verificar();
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("    |" + evento[i] + "|    " + Tabla[0][i] + "|    " + Tabla[1][i] + "|    " + Tabla[2][i] + "|    " + Tabla[3][i]);
            }
            Console.ReadKey();
        }
    }
}
