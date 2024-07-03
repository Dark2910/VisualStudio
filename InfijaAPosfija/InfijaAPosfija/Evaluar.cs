using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfijaAPosfija
{
    
    class Pila<T>
    {
        
        //ATRIBUTOS
        T[] vec;
        int tam;
        int tope;
        bool vacia;
        bool llena;
        //CONSTRUCTOR
        public Pila(int n)
        {
            tam = n;
            vec = new T[tam];
            tope = 0;
            vacia = true;
            llena = false;
        }
        //METODOS
        public void Push(T valor)
        {
            vacia = false;
            vec[tope++] = valor;
            if (tope == tam)
                llena = true;
        }
        public T Pop()
        {
            llena = false;
            if (--tope == 0)
            {
                vacia = true;
            }
            return vec[tope];
        }
        public bool esta_Vacia()
        {
            return vacia;
        }
        public bool esta_Llena()
        {
            return llena;
        }
        public T Tope()
        {
            return vec[tope - 1];
        }
    }
}

