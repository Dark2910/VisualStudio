using System;

namespace Numeros_Pseudoaletorios
{
    class Program
    {
        //Metodo Congruencial
        static double MetodoCongruencial(int a, int m)
        {
            int mrc;
            double na;

            if (m == 0)
            {
                return 0;
            }

            mrc = a % m;

            na = Math.Truncate((double)mrc / m * 1000)/1000;

            return na;
        }
        //Potencias Sucesivas
        static void PotenciasSucesivas(int a, int i, int m)
        {
            int j, mrc;
            double ai, na;

            for (j=1; j<=i; j++)
            {
                ai = Math.Pow(a,j);
                mrc = (int)ai % m;
                na = Math.Truncate((double)mrc / m * 1000) / 1000;
                ai = mrc;

                Console.WriteLine(na);
            }
        }
        //Metodo Aditivo
        static void MetodoAditivo(int a, int n0, int m)
        {
            int a2, ni, mrc;
            double na;

            ni = n0;

            for (int i = 1; i<=m; i++)
            {
                a2 = a + ni;
                mrc = a2 % m;
                na = Math.Truncate((double)mrc / m * 1000) / 1000;
                ni = mrc;

                Console.WriteLine(na);
            }
        }
        //Metodo Mixto
        static void MetodoMixto(int a, int c, int n0, int m)
        {
            int a2, ni, mrc;
            double na, i;

            ni = n0;
            na = 0;
            i = 0;

            do
            {
                if (i == 0)
                {
                    i = na;
                }

                a2 = (a * ni) + c;
                mrc = a2 % m;
                na = Math.Truncate((double)mrc / m * 100000) / 100000;
                ni = mrc;

                if (na != i)
                {
                    Console.WriteLine(na);
                }
                
            } while (na != i);
        }
        //Metodo Multiplicativo Binario
        static void MetodoMultiplicativoBinario(int a, int b, int n0)
        {
            int  ni, s;
            double na;
            String n;

            ni = n0;

            for (int i=0; i<b; i++)
            {
                n = "" + ConvertirABinario(a * ni);
                Console.WriteLine(a + "*" + ni + " = " + a * ni + " = " + n);
                s = (n.Length - b);
                n = n.ToString().Substring(s, b);
                ni = (int)ConvertirADecimal(n);
                na = ni / (Math.Pow(2, b));
                Console.WriteLine("n= " + n + "; " + ni + "/" + (Math.Pow(2, b)) + "; " + na);
            }
        }
        static int ConvertirABinario(int num)
        {
            int n = num;
            String nb = "";

            if (n > 0)
            {
                while (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        nb = "0" + nb;
                    }
                    else
                    {
                        nb = "1" + nb;
                    }
                    n = (int)(n / 2);
                }
                return int.Parse(nb);
            }
            return 0;
        }
        static double ConvertirADecimal(String num)
        {
            int n;
            double d;

            d = 0;
            n = int.Parse(num);

            for (int i = 0; i <= num.Length; i++)
            {
                d = d + ((n % 10) * Math.Pow(2, i));
                n = n / 10;
            }
            return d;
        }
        //Metodo de la Centena
        static void MetodoDeLaCentena(double d)
        {
            int a, m, mrc;
            string v;
            double na;

            m = 0;

            v = d.ToString().Substring((d.ToString().IndexOf('.') + 1), 
                (d.ToString().Length)-(d.ToString().IndexOf('.') + 1) );

            if (v.Length < 5)
            {
                Console.WriteLine("La muestra tiene que ser mayor o igual a 5 digitos");

            }
            else
            {
                a = int.Parse(v);

                for (int i = 0; i < v.Length; i++)
                {
                    m += int.Parse(v.Substring(i, 1));
                }

                mrc = a % m;
                na = Math.Truncate((double)mrc / m * 10000) / 10000;

                Console.WriteLine(a + " mod " + m + " = " + mrc + "\n" + mrc + "/" + m + " = " +  na);
            }
        }
        //Cuadrados Medios
        static void CuadradosMedios(int a, int b, int c)
        {
            double valor, p, na, suma;
            int d1, d2;
            String m1, m2, n1, n2;

            suma = 0;
            valor = c;

            for (int i=0;i<a;i++)
            {
                p = Math.Pow(valor, 2);
                Console.WriteLine(valor + "^2= " + p);

                //mitad uno
                m1 = p.ToString().Substring(0, p.ToString().Length / 2);

                //mitad dos
                m2 = p.ToString().Substring(p.ToString().Length / 2, p.ToString().Length - p.ToString().Length / 2);

                //numero de digitos a tomar de cada mitad
                d1 = b / 2;
                d2 = b - d1;

                //nuevo digito 1
                n1 = m1.ToString().Substring(m1.ToString().Length - d1, d1);

                //nuevo digito 2
                n2 = m2.ToString().Substring(0, d2);

                //numero pseudoaleatorio
                na = int.Parse(n1 + n2);
                valor = na;
                Console.WriteLine("na= " + na);

                na = na / Math.Pow(10, na.ToString().Length);
                Console.WriteLine("na= " + na);

                suma += na;
            }
            Console.WriteLine("Suma     = " + suma);
        }
        //Generar Numeros
        static void GenerarNumeros(int n)
        {
            int rango, entero, m;
            Random random;
            double valor, na;

            rango = 0;
            do
            {
                random = new Random();
                valor = random.NextDouble();
                entero = (int)Math.Truncate(valor * 10);   
                m = entero + (int)Math.Truncate(random.NextDouble() * 100); 

                na = MetodoCongruencial(entero,m);
                Console.WriteLine(na);

                rango++;
            } while (rango < n);

        }
        static void Main(string[] args)
        {
            int a, b, c, d;
            String opciones = "9";

            Console.WriteLine("Numeros Pseudoaleatorios");

            do
            {
                Console.Write("\nIngresa el número de las siguientes opciones." +
                       "\n1- Metodo Congruencial." +
                       "\n2- Metodo Potencias Sucesivas." +
                       "\n3- Metodo Aditivo." +
                       "\n4- Metodo Mixto." +
                       "\n5- Metodo Multiplicativo Binario." +
                       "\n6- Metodo de la Centena." +
                       "\n7- Metodo de cuadrados medios." +
                       "\n8- Generar n números." +
                       "\n9- Salir\n");

                opciones = Console.ReadLine();

                switch (opciones)
                {
                    case "1":

                        Console.WriteLine("Metodo Congruencial\nIngresa el valor de a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de m");
                        b = int.Parse(Console.ReadLine());

                        Console.WriteLine(MetodoCongruencial(a, b));
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "2":

                        Console.WriteLine("Metodo Potencias Sucesivas\nIngresa el valor de a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de i");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de m");
                        c = int.Parse(Console.ReadLine());

                        PotenciasSucesivas(a, b, c);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "3":

                        Console.WriteLine("Metodo Aditivo\nIngresa el valor de a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de n0");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de m");
                        c = int.Parse(Console.ReadLine());

                        MetodoAditivo(a, b, c);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "4":

                        Console.WriteLine("Metodo Mixto\nIngresa el valor de a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de c");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de n0");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de m");
                        d = int.Parse(Console.ReadLine());

                        MetodoMixto(a, b, c, d);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "5":

                        Console.WriteLine("Metodo Multiplicativo Binario\nIngresa el valor de a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de b");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el valor de n0");
                        c = int.Parse(Console.ReadLine());

                        MetodoMultiplicativoBinario(a, b, c);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "6":

                        Console.WriteLine("Metodo de la centena\nIngresa el valor de a");
                        double e = Double.Parse(Console.ReadLine());

                        MetodoDeLaCentena(e);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "7":

                        Console.WriteLine("Metodo de cuadrados medios\n¿Cuantos numeros deseas generar?");
                        a= int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la cantidad de digitos que se desea en el numero pseudoaleatorio");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa tu semilla");
                        c = int.Parse(Console.ReadLine());

                        CuadradosMedios(a, b, c);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "8":

                        Console.WriteLine("Generar n números\n¿Cuantos números deseas?");
                        a = int.Parse(Console.ReadLine());

                        GenerarNumeros(a);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "9":

                        Console.WriteLine("\n¿Deseas cerrar el programa? Y/N.");
                        opciones = Console.ReadLine();
                        if (opciones == "Y" || opciones == "y")
                        {
                            opciones = "9";
                        }
                        else if (opciones == "N" || opciones == "n")
                        {
                            opciones = "";
                            Console.Clear();
                        }

                        break;
                    default:

                        Console.WriteLine("Argumento invalido.");
                        Console.Clear();

                        break;
                }
            } while (opciones != "9");
        }
    }
}
