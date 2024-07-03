using System;
using System.Collections.Generic;
using System.Text;

namespace Orden
{
    class NumAle
    {
        private Random random;
        private double valor;
        protected int entero, rango, i;
        //lista -> reemplaza un arrayList
        protected List<int> colector = new List<int>();
        /*Constructor*/
        public NumAle()
        {
            this.random = new Random();
            this.valor = 0;
            this.entero = 0;
            this.rango = int.Parse(Console.ReadLine());
            this.i = 0;
        }
        /*Metodo*/
        private String Aleatorio()
        {
            /*Recursividad*/
            //if (i < rango)
            //{
            //    valor = random.NextDouble();
            //    entero = (int)Math.Truncate(valor * 100000); /*Casting*/
            //    colector.Add(entero);
            //    Console.WriteLine(colector[i]);
            //    i++;
            //    return Aleatorio();
            //}
            //return "";

            rango += 0;
            do
            {
                valor = random.NextDouble();
                entero = (int)Math.Truncate(valor * 1000000); /*Casting*/
                colector.Add(entero);
                i++;
            } while (i < rango);
            return "";
        }
        public void Numero()
        {
            Aleatorio();
        }
    }
}
