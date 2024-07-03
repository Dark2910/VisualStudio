using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_dinamica
{
    public partial class Form1 : Form
    {
        //Arreglo dinamico?
        List<List<String>> AgendaDinamica = new List<List<string>>();
        int i = 0;
        string box = "";

        public Form1()
        {   
            InitializeComponent();
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            if (Rb_Guardar.Checked == true)
            {
                AgendaDinamica.Add(new List<string>());
                AgendaDinamica[i].Add(TxtBox_Nombre.Text);
                AgendaDinamica[i].Add(TxtBox_ApPaterno.Text);
                AgendaDinamica[i].Add(TxtBox_ApMaterno.Text);
                AgendaDinamica[i].Add(TxtBox_Telefono.Text);
                AgendaDinamica[i].Add(TxtBox_Correo.Text);
                i++;

            }

            TxtBox_Nombre.Clear();
            TxtBox_ApPaterno.Clear();
            TxtBox_ApMaterno.Clear();
            TxtBox_Telefono.Clear();
            TxtBox_Correo.Clear();

            if (Rb_Imprimir.Checked == true)
            {
                for (int k = 0; k < AgendaDinamica.Count; k++)
                {
                    int a;
                    for (a = 0; a < AgendaDinamica[k].Count; a++)
                    {
                        box += AgendaDinamica[k][a] + " ";

                    }
                    box += "\n";
                }
                MessageBox.Show(box);
            }
        }
    }
}
