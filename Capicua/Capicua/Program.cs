using System;

namespace Capicua
{
    class Program
    {                                           
        static long Longitud(long num)          //Obtengo un numero    
        {
            long n, contador;                   //Declaro dos variables 
            n = num;                            //n es la copia del valor obtenido
            contador = 0;                       //contador va a ser el total de digitos que posee el numero pero lo declarammos como 0
            do                                  //Declaro un ciclo loop 
            {
                n = n / 10;                     //Dentro del ciclio divido la copia entre diez
                contador += 1;                  //Aumento el contador de uno en uno despues de haber dividido la copia 

            } while (n > 0);                    //Si n es igual a 0 el ciclo el loop se detiene 
            return contador;                    //Retornamos la variable contador 
        }
        static long Invertir (long num)         //Obtengo un numero 
        {
            long n, l, d;                       //Declaramos cuatro variables 
            double v;

            d = 0;                              //igualamos la variable d a 0
            v = 0;                              //igualamos la variable v a 0
            n = num;                            //n es la copia del valor obtenido
            l = Longitud(n);                    //l va a ser la longitud de la variable n
            //l = n.ToString().Length;

            do                                  //Declaramos un ciclo 
            {
                l = l - 1;                      //Restamos de uno en uno la variable l 
                d = n % 10;                     //d va a ser el residuo que resulta de la divison de la variable n con el numero 10
                n = n / 10;                     //Sobrescribimos la variable n dividiendo n etre 10
                v = v + d * Math.Pow(10, l);    //Sobrescribimos la variable v donde va a ser igual a la suma de v con la variable d, d va a ser multiplicada por 10 elevado por la variable l 


            } while (l > 0);                    //Mientras la varable l sea mayor a 0 el loop va a continuar 
            return (long)v;                     //Retornamos la varible v como el valor de n invertido
        }
        static void Capicua(int num)            //Obtengo un numero 
        {
            long n;                             //Declaramos una variable 

            n = num;                            //La variable n va a ser una cop

            do                                  //Declaramos un ciclo loop que va a seguir mientras la variale n sea diferente del inverso de la misma 
            {
                Console.WriteLine("Valor: "+n+"\nInverso: " + Invertir(n));                          //Imprimimos la copia y el inverso de esta 

                n = n + Invertir(n);            //Sobrescribimos la variable n en donde esta va a ser igual a la suma de n con en inverso de esta  

                Console.WriteLine("Suma: " + n + "\nSuma invertida: " + Invertir(n)+ "\n");         //Imprimimos la suma  y su inverso 

                if (n == Invertir(n))           //Declaramos un condicional donde si n es igual a su inverso  el loop se detiene
                {
                    Console.WriteLine(Invertir(n) + " es su numero Capicua");   //Si la condicion de cumple antes de detener el ciclo imprimimos el inverso de n e indicamos que es un numero Capicua 
                    break;
                }

            } while (n != Invertir(n));
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Numero Capicua\nIngresa un valor");
            a = int.Parse(Console.ReadLine());
            Capicua(a);
            Console.ReadLine();
        }
    }
}
