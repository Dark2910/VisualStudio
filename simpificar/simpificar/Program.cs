using System;

namespace simpificar
{
    class Program
    {
        static long Longitud(long num)
        {
            long n, contador;
            n = num;
            contador = 0;
            do
            {
                n = n / 10;
                contador += + 1;

            } while (n>0);

            return contador;
        }

        static int Invertir (String num)
        {
            int n, d, contador;
            double v;

            n = int.Parse(num);
            d = 0;
            v = 0;
            contador = num.Length;

            do
            {
                contador -= 1;
                d = n % 10;
                n = n / 10;
                v = v + d * Math.Pow(10, contador); //Math.Pow -> potencia

            } while (n > 0);

            return (int)v;
        }

        static int Cuenta (int num , int v)
        {
            int n=num, c=0;

            do
            {
                if (n == 0)
                {
                    return c;
                }

                if (n % 10 == v){
                    c += +1;
                }

                n = n/10;

            } while (n >= 0);
            return 0;
        }

        static int Primo(int pn)
        {
            int vn=pn, vd=2, vc=0;
            do
            {
                if (vd == vn)
                {
                    break;
                }

                if (vn % vd == 0)
                {
                    vc += 1;
                }

                vd += 1;
            } while (vd <= vn);

            if (vc == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static String ReducirFraccion(int num, int den)
        {
            int n = num, d = den, l = 0, mcd = 2, p = 0;

            if (n == 0)
            {
                return "0";
            }
            if (d == 0)
            {
                return "Error";
            }

            if (n > d)
            {
                l = n;
            }
            else
            {
                l = d;
            }

            do
            {
                p = Primo(mcd);

                if (p == 1)
                {
                    if (n % mcd == 0 && d % mcd == 0)
                    {
                        n = n / mcd;
                        d = d / mcd;

                        mcd=2;
                    }
                    else
                    {
                        mcd += + 1;
                    }
                }
                else
                {
                    mcd += + 1;
                }

            } while (mcd <= l);

            return n + "/" + d;
        }

        static String Machetazos(int num, int den)
        {
            int n, d, cn, cd, q, l, dn, dd, nn, nd, qn, qd;
            Boolean bn, bd , p;
            String s, ns;

            n = num;
            d = den;
            cn = 0;
            cd = 0;
            q = 0;
            l = 0;
            dn = 0;
            dd = 0;
            nn = 0;
            nd = 0;
            qn = 0;
            qd = 0;

            bn = false;
            bd = false;
            p = false;

            s = ReducirFraccion(n,d);
            ns = "";

            //¿Se puede hacer o no el metodo?
            cn = Cuenta(n, 3) + Cuenta(n, 6);
            cd = Cuenta(d, 3) + Cuenta(d, 6);

            if (cn == 0 && cd == 0)
            {
                return "No se puede resolver por este metodo";
            }
            //Total de digitos a quitar
            if (cn < cd && cn>0)
            {
                q = cn;
            }
            else
            {
                q = cd;
            }
            cn = 0;
            cd = 0;
            //limite del ciclo
            if (n > d)
            {
                l = n;
            }
            else
            {
                l = d;
            }
            for (int i = 1; i <= Longitud(l) ; i++)
            {
                dn = n % 10;
                n = n / 10;

                //Console.WriteLine("Residuo de dn= " + dn);

                dd = d % 10;
                d = d / 10;

                //Console.WriteLine("Residuo de dd= " + dd);

                if (p == false)
                {
                    if (bn == false)
                    {
                        if (dn == 3 || dn == 6)
                        {
                            qd = dn;
                            cn += 1;
                            //Console.WriteLine("qd= " + qd);
                            bn = true;
                        }
                    }
                    if (bd == false)
                    {
                        if (dd == 3 || dd == 6)
                        {
                            qn = dd;
                            cd += 1;
                            //Console.WriteLine("qn= " + qn);
                            bn = true;
                        }
                    }
                }
                if (dn != 6 && dn != qd || dn != 3 && dn != qd)
                {
                    nn = int.Parse(nn.ToString() + dn.ToString());
                    bn = false;
                    //Console.WriteLine("nn= " + nn + "\ncn = " + cn);
                }
                if (dd != 6 && dd != qn || dd != 3 && dd != qn)
                {
                    nd = int.Parse(nd.ToString() + dd.ToString());
                    bd = false;
                    //Console.WriteLine("nd= " + nd + "\ncd = " + cd);
                }
                if (cn == q && cd == q)
                {
                    p = true;
                }
            }

            nn = Invertir(nn + "");
            nd = Invertir(nd + "");
            ns = ReducirFraccion(nn, nd);

            Console.WriteLine("Simplificacion normal: " + s + "\nMachetazos matematicos: " + nn + "/" + nd);

            if (ns.Equals(s))
            {
                return "Se puede reducir por este medoto";
            }
            
            return "No se puede reducir por este medoto";
        }
        static void Main(string[] args)  
        {
            /*Console.ReadLine (): Método que acepta y devuelve un String (cadena).
            Console.Read (): Método que acepta un String pero devuelve un Integer.
            Console.ReadKey (): Método que acepta un Char y retorna el valor ASCCI de ese Char.
            Un String es un arreglo de char el String va con comillas dobles "hola" y el char con simples 'h'*/

            //Console.WriteLine("Cuantos digitos tiene un numero\nIngresa una cantidad");
            //long num = long.Parse(Console.ReadLine());
            //Console.WriteLine(Longitud(num));
            //Console.ReadKey();

            //Console.WriteLine("Invertir numeros \nIngresa un digito");
            //String num = Console.ReadLine();
            //Console.WriteLine(Invertir(num));
            //Console.ReadKey();

            //Console.WriteLine("Numeros repetidos\nIngresa un digito");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa el numero a buscar");
            //int v = int.Parse(Console.ReadLine());
            //Console.WriteLine(Cuenta(num, v));
            //Console.ReadKey();

            //Console.WriteLine("Es un umero primo");
            //int n = int.Parse(Console.ReadLine());
            //int p = Primo(n);
            //Console.WriteLine(p);
            //Console.ReadKey();

            //Console.WriteLine("Reducir una fraccion \nIngresa el numerador");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa el denominador");
            //int den = int.Parse(Console.ReadLine());
            //Console.WriteLine(ReducirFraccion(num, den));
            //Console.ReadKey();

            Console.WriteLine("Machetazos \nIngresa el numerador");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el denominador");
            int den = int.Parse(Console.ReadLine());
            Console.WriteLine(Machetazos(num, den));
            Console.ReadKey();
        }
    }
}
