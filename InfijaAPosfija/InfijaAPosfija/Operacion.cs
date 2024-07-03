using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfijaAPosfija
{
    enum Simbolo { OPERANDO, PIZQ, PDER, SUMRES, MULTDIV};
    class A_notacion_polaca
    {
       
        
        //METODO QUE REGRESA UN StringBuilder (EXPRESION A POSTFIJA) Y RECIBE UN STRING(EXPRESION INFIJA)
        public StringBuilder ConvertirPosFija(string Ei)
        {
            char[] Epos = new char[Ei.Length];
            int tam = Ei.Length;
            Pila<int> stack = new Pila<int>(Ei.Length);
            int i, pos = 0;
            for (i = 0; i < Epos.Length; i++)
            {
                char car = Ei[i];
                Simbolo actual = Tipo_y_Prescedencia(car);
                switch (actual)
                {
                    case Simbolo.OPERANDO: Epos[pos++] = car; break;
                    case Simbolo.SUMRES:
                        {
                            while (!stack.esta_Vacia() && Tipo_y_Prescedencia((char)stack.Tope()) >= actual)
                                Epos[pos++] = (char)stack.Pop();
                            stack.Push(car);
                        }
                        break;
                    case Simbolo.MULTDIV:
                        {
                            while (!stack.esta_Vacia() && Tipo_y_Prescedencia((char)stack.Tope()) >= actual)
                                Epos[pos++] = (char)stack.Pop();
                            stack.Push(car);
                        }
                        break;
                 
                      
                    case Simbolo.PIZQ: stack.Push(car); break;
                    case Simbolo.PDER:
                        {
                            char x = (char)stack.Pop();
                            while (Tipo_y_Prescedencia(x) != Simbolo.PIZQ)
                            {
                                Epos[pos++] = x;
                                x = (char)stack.Pop();
                            }
                        }
                        break;
                }
            }
            while (!stack.esta_Vacia())
            {
                if (pos < Epos.Length)
                    Epos[pos++] = (char)stack.Pop();
                else
                    break;
            }
            StringBuilder regresa = new StringBuilder(Ei);
            for (int r = 0; r < Epos.Length; r++)
                regresa[r] = Epos[r];
            return regresa;
        }
        //METODO QUE REGRESA UN ENUM Y RECIBE UN char (operador)
        public Simbolo Tipo_y_Prescedencia(char n)
        {
            Simbolo simbolo;
            switch (n)
            {
                case '+': simbolo = Simbolo.SUMRES; break;
                case '-': simbolo = Simbolo.SUMRES; break;
                case '*': simbolo = Simbolo.MULTDIV; break;
                case '/': simbolo = Simbolo.MULTDIV; break;
                case '(': simbolo = Simbolo.PIZQ; break;
                case ')': simbolo = Simbolo.PDER; break;
                default: simbolo = Simbolo.OPERANDO; break;
            }
            return simbolo;
        }
    }

}
