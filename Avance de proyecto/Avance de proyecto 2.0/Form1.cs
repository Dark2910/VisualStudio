using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance_de_proyecto_2._0
{
    public partial class Form1 : Form
    {
        Stack pila = new Stack();
        Queue cola = new Queue();
        String serie = "";
        int conteo = 0;
        int resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Ok_Click(object sender, EventArgs e)
        {
            String caja = TxtBox_SerieNumerica.Text;

            for (int i = 0; i < caja.Length; i++)
            {
                String separacion = caja.Substring(i, 1);

                if (separacion.Equals("+") || separacion.Equals("-") || separacion.Equals("*") || separacion.Equals("/") || separacion.Equals("(") || separacion.Equals(")"))     //pila
                {
                    if (pila.Count == 0)
                    {
                        pila.Push(separacion);       //Guardar signo
                    }
                    else if (separacion.Equals("+") || separacion.Equals("-"))
                    {
                        if (pila.Peek().Equals("+") || pila.Peek().Equals("-"))
                        {
                            serie += pila.Peek();
                            pila.Pop();    
                            pila.Push(separacion);      
                        }
                    } else if (separacion.Equals("*") || separacion.Equals("/"))
                    {
                        if (pila.Peek().Equals("+") || pila.Peek().Equals("-"))
                        {
                            //pila.Push(separacion);
                            //serie += pila.Peek();
                            //pila.Pop();
                            pila.Push(separacion);
                        }
                        else if (pila.Peek().Equals("*") || pila.Peek().Equals("/"))
                        {
                            serie += pila.Peek();
                            pila.Pop();
                            pila.Push(separacion);
                        }
                        else
                        {
                            pila.Push(separacion);
                        }
                    }
                    else if(separacion.Equals("("))
                    {

                    }
                    else if(separacion.Equals(")"))
                    {
                        for (int j = 0; j < caja.Length; j++)
                        {
                            separacion = caja.Substring(j, 1);
                            if (separacion.Equals("+") || separacion.Equals("-") || separacion.Equals("*") || separacion.Equals("/")) 
                            {
                                for (int k = 0; k < pila.Count; k++)
                                {
                                    serie += pila.Peek();
                                    pila.Pop(); ;
                                }
                            }
                        }
                    }
                }
                else
                {
                    cola.Enqueue(separacion);       //Guardar numero
                    serie += separacion;
                }
            }
            while (serie.Length < caja.Length)
            {
                serie += pila.Peek();
                pila.Pop();;
            }
            TxtBox_NotacionPolaca.Text = serie;
            serie = "";

            Int32.TryParse(TxtBox_SerieNumerica.Text, out resultado);
            TxtBox_Resultado.Text = "" + resultado;

        }

        private void Button_Cola_Click(object sender, EventArgs e)
        {
            String caja = TxtBox_SerieNumerica.Text;
            foreach (var i in caja)
            {
                string numero = " " + i + " ";
                if (numero.Equals(" + ") || numero.Equals(" - ") || numero.Equals(" * ") || numero.Equals(" / ") || numero.Equals(" ( ") || numero.Equals(" ) ") 
                    )
                {
                    cola.Equals(numero);
                }
                else
                {
                    cola.Enqueue(i);    //Guardar números
                }
            }
            conteo = cola.Count;
            for (int i = 0; i < conteo; i++)        //cola
            {
                MessageBox.Show("Dato guardado en cola " + cola.Dequeue());     //Eliminar dato       
            }
            pila.Clear();
        }

        private void Button_Pila_Click(object sender, EventArgs e)
        {
            String caja = TxtBox_SerieNumerica.Text;

            for (int j = 0; j < caja.Length; j++)
            {
                String signo = caja.Substring(j, 1);        //pila

                if (signo.Equals("+") || signo.Equals("-") || signo.Equals("*") || signo.Equals("/") || signo.Equals("(") || signo.Equals(")"))     //pila
                {
                    pila.Push(signo);
                }
                else
                {
                    pila.Equals(signo);
                }
            }
            conteo = pila.Count;
            for (int i = 0; i < conteo; i++)        //pila
            {
                MessageBox.Show("Dato guardado en pila " + pila.Pop());     //Eliminar dato 
            }
            cola.Clear();
        }

        private void Button_Limpiar_Click(object sender, EventArgs e)
        {
            TxtBox_NotacionPolaca.Clear();
            TxtBox_Resultado.Clear();
            TxtBox_SerieNumerica.Clear();
            pila.Clear();
            cola.Clear();
        }
    }
}
