using System;
using System.Collections.Generic;
using System.Text;

namespace Orden
{
    //Herencia
    class Clasi : NumAle
    {
        protected int limite, j, nc, d, p0, p1, p2, p3, p4, p5;
        protected String n1, n2;
        /*Constructor*/
        public Clasi()
        {
            this.limite = rango;
            this.j = 0;
            this.nc = 0;
            this.d = 0;
            this.n1 = "";
            this.n2 = "";
            this.p0 = 0;
            this.p1 = 0;
            this.p2 = 0;
            this.p3 = 0;
            this.p4 = 0;
            this.p5 = 0;
        }
        //Metodo
        private String Separar()
        {
            Numero();
            do
            {
                n1 = colector[j].ToString();
                nc = n1.Length;  //Número de caracteres de la cadena
                n2 = n1.Substring(1,nc-1);   //Nueva cadena en base a "n1" 
                d = n2.IndexOf(n1.Substring(0, 1)) +1;  //Distancia del valor que es igual al primero
                if (d==0)
                {
                    p0++;
                }else if (d==1)
                {
                    p1++;
                }else if (d==2)
                {
                    p2++;
                }else if (d==3)
                {
                    p3++;
                }else if (d==4)
                {
                    p4++;
                }else if (d==5)
                {
                    p5++;
                }
                Console.WriteLine(n1 + " Distancia: " + d);
                j++;
            } while (j<limite);
            Console.WriteLine("\nNúmeros con distancia igual a cero " + p0 + "\nNúmeros con distancia igual a uno  " + p1 +
                "\nNúmeros con distancia igual a dos " + p2 + "\nNúmeros con distancia igual a tres " + p3 +
                "\nNúmeros con distancia igual a cuatro " + p4 + "\nNúmeros con distancia igual a cinco " + p5);
            return "";
        }
        public void Orden()
        {
            Separar();
        }
    }
}
