using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busqueda_binaria_forms
{
    public partial class Form1 : Form
    {
        int numero, puntero = 0, final = 9, mitad = -999;
        int[] vec = { 3, 8, 11, 22, 38, 49, 50, 56, 62, 70 };
        bool encontro = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonencontrar.Checked==true)
            {
                numero = int.Parse(textBoxNUMERO.Text);
                while (!encontro && puntero <= final)
                {
                    mitad = (int)((puntero + final) / 2);

                    if (numero == vec[mitad])
                        encontro = true;
                    else if (numero < vec[mitad])
                        final = mitad - 1;
                    else
                        puntero = mitad + 1;
                    if (encontro)
                        MessageBox.Show("El dato fue hallado y se encuentra en la posicion:  " + (mitad + 1));
                    textBoxNUMERO.Clear();
                }
            }
            else
            {       
                    MessageBox.Show("No se encontro el dato.");

                textBoxNUMERO.Clear();
            }
        }
    }
}
