using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfijaAPosfija
{

    //class A_notacion_polacC:\Users\Eduardo\source\repos\InfijaAPosfija\InfijaAPosfija\Evaluar.cs
    class A_notacion_polacC 
    {
        
        static public double Resultado(string expresion)
        {
            
            int operador1 = 0;
            int operador2 = 0;
            int respuesta = 0;
            Stack  pilA = new Stack();

            
            for (int i = 0; i < expresion.Length; i++)
            {
               
                if (expresion[i] >= '0' && expresion[i] <= '9')
                {
                    pilA.Push(expresion[i] - '0');
                }
                
                if (expresion[i] == '+' || expresion[i] == '-' || expresion[i] == '/' || expresion[i] == '*' || expresion[i] == '^')
                {
                    
                    operador2 = Convert.ToInt32(pilA.Pop());
                    operador1 = Convert.ToInt32(pilA.Pop());

                   
                    switch (expresion[i])
                    {
                        case '+':
                            respuesta = operador1 + operador2;
                            break;
                        case '-':
                            respuesta = operador1 - operador2;
                            break;
                        case '*':
                            respuesta = operador1 * operador2;
                            break;
                        case '/':
                            respuesta = operador1 / operador2;
                            break;                       
                    }

                   
                    pilA.Push(respuesta);
                }
            }
           


            return respuesta;
        }

        public static void ppila()
        {
            Stack op = new Stack();
            Queue num = new Queue();
            string cad="0";

            for(int i = 0; i < cad.Length; i++)
            {
                string car = cad.Substring(i, 0);

                if(car.Equals("+")|| car.Equals("-")|| car.Equals("*") || car.Equals("/"))
                {
                    op.Push(car);

                }
                else
                {
                    num.Enqueue(car);
                }

                if(car.Equals("*")|| car.Equals("+")|| car.Equals("/")|| car.Equals("-"))
                {
                    if (op.Peek().Equals("+")|| op.Peek().Equals("-")|| op.Peek().Equals("*")|| op.Peek().Equals("/"))

                        op.Push(car);
                }
            }

            op.Push(cad);
        }
        

    }
}

