using System;

namespace RaizCuadrada
{
    class Program
    {
        static long Longitud(long num)  //Obtenemos un numero al cual le vamos a contar el numero de digitos
        {
            long n, contador;
            n = num;    //"n" va a ser una copia del numero obtenido
            contador = 0;
            do  //Declaramos un ciclo while
            {
                n = n / 10; //Vamos a sobrescribir la variable n dividiendola entre 10 n cantidad de veces 
                contador += +1; //Aumentamos el contador de uno en uno cada vez que sobrescribimos la variable n

            } while (n > 0);    //Dentro del ciclo while la condicion dice que el cilico continuara mientras la variable n sea mayor a 0

            return contador;    //Retornamos la variable contador ya que esta se va a convertir en el numero de digitos que posee la variable n
        }
        static int Entero(int n)   //Obtenemos un valor al cual le vamos a calcular su raiz cuadrada perfecta
        {
            int p = 0;  //La variable p va a funcionar como contador 

            do
            {
                p++;
            } while (Math.Pow(p, 2) <= n);  /*La condicion indica que mientas el contador (variable j) elevada al cuadrado sea menor 
                                             * o igual al valor a calcular  el ciclo continue*/

            return p - 1; //La vaiable p pasa a ser la raiz cudrada perfecta del valor recibido pero antes de retornarla hay que restar una unidad
        }
        static double Decimal(int n, int m) //Recibimos el valor de la raiz cuadrada perfecta (variable n) y el valor de la variable r
        {
            int j = 0;
            double d = 0, c, p;

            c = (n * 2) * 10;  //La variable c va a ser el limite del ciclo whie (Como regla hay que multiplicar por dos el valor de la raiz cuadrada perfecta y aumentar un decimal)
            p = m;  //Parada del ciclo while

            for (int i = 1; i >= 0; i--)    //Declaramo un ciclo for para generar dos valores en el punto decimal de la raiz
            {
                do  //obtenemos el decimal de la fraccion
                {
                    j++;
                } while (((c + j) * j) <= p);   /*La condicion indica que mientras la variable c más el valor de j multiplicado por j 
                                                 sea menor o igual al valor de la parada este continuara*/

                // j - 1 va a ser igual al decimal que se tiene que agregar al resultado

                p = (p - (c + j - 1) * (j - 1)) * Math.Pow(10, 2);  /*Sobrescribimos la variable p para obtener una nueva parada y 
                                                                     * aplicamos los pasos antes mencionados para la varible r*/

                c = ((n * 10 + j - 1) * 2) * 10; /*Sobrescribimos la variable c para obtener un nuevo comienzo y aumentamos dos unidades como la vez pasada*/

                d = d + (j - 1) * Math.Pow(10, i);  //La variable d va a ser la encargada de acumular y concatenar las dos decimales calculados 
                j = 0;
            }
            return d;
        }
        static void Raiz(double a)
        {
            double n, r, d;

            n = Entero((int)a); //Obtenemos la raiz cuadrada perfecta mas cercana al valor recibido

            //Sabiendo que la variable n es igual a la raiz cuadrada perfecta mas cercana al valor recibido, obtenemos la diferencia respecto a la variable a
            r = (a - Math.Pow(n, 2)) * Math.Pow(10, 2);  /*Continuando con la explicacion anterior la variable r va a ser esa diferencia, 
                                                           * pero como parte del procedimiento tenemos que aumentarle dos decimales*/

            d = 0;  //La variable d va a ser la encargada de acumular los decimales a calcular 

            if (a - Math.Pow(n, 2) != 0) //En caso de que la diferencia sea diferente de 0 vamos a ejecutar el codigo siguiente 
            {
                d = Decimal((int)n, (int)r); //Obtenemos los decimales (estos se encuentran como valor entrero)

                d /= Math.Pow(10, Longitud((long)d)); //Pasamos los decimales a punto decimal
            }

            n = n + d;  //sumamos el valor de la raiz cuadrada perfecta con los decimales obtenidos 

            Console.WriteLine("Resultado: " + n);
        } 

        /*---------------------------------------------------------Ejercicio Pedro Ivan-----------------------------------------------------------------------*/

        static int Valores(int a)   //Obtenemos un valor te tipo entero 
        {
            //Declaramos tres variables 
            int n, d, v;
            //Igualamos las variables "n" y "v" al valor recibido e igualamos la variable d a cero 
            n = a;
            d = 0;
            v = a;
            //Declaramos un condicional el cual va a funcionar como parada, en donde si la longitud (tamaño) de la variable "v" es mayo a 1 se va a ejecutar el codigo dentro del condicional 
            if (Longitud(v) > 1)
            {
                v = 0;  //Igualamos la variable "v" a cero 
                do
                {
                    d = n % 10; //Obtenemos el residuo de la variable "n" dividio entre 10 y lo almacenamos en la variable "d"
                    n = n / 10; //Sobrescribimos la variable n quitando una unidad, unidad que ya se almaceno en la variable "d"
                    v = v + d;  //Acumulamos el valor de la variable "d" en la variable "v" (esto es en la primera vuelta), despues la variable "v" va a ir sumando los valores conforme los vaya recibiendo

                } while (n > 0);    //Este ciclo se va a repetir hasta que el valor de "n" sea menor o igual a cero 

                return Valores(v);  /*Mandamos a llamar al mismo metodo con el fin de volver a sumar el valor que adquirio "v",
                                     *esto se va a repetir hasta que el valor sea de una sola unidad*/
            }
            return v;   //Retornamos el valor de "v" una vez que el numero de digitos que posee es igual a 1 
        }

        static void RangoRaizDigital(int c, int f)  //Obtenemos un rango donde la variable "c" va a ser el comienzo y la varibale "f" sera el final
        {
            int rd; //Declaramos la variable "rd", esta va a ser utilizada para obtener la raiz digital
            
            for (int i = c; i <= f; i++)    //Creamos un ciclo for utilizando los valores de las variables "c" y "f"
            {
                rd = Valores(i);    //Obtenemos la raiz digital del valor que obtiene la variable "i"

                Console.WriteLine("Raiz digital de: " + i + " es " + rd);   //Imprimimos el valor de la variable "i" y su raiz digital (variable rd)
            }
        }

        static void Main(string[] args)
        {
            double a, b;

            //Console.WriteLine("Raiz cuadrada\nIngresa un numero");
            //a = double.Parse(Console.ReadLine());
            //Raiz(a);
            //Console.ReadLine();

            Console.WriteLine("Raiz digital\nIngresa un rango inicial");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un rango final");
            b = double.Parse(Console.ReadLine());
            RangoRaizDigital((int)a, (int)b);
            Console.ReadLine();
        }
    }
}
