using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_con_matriz
{
    public partial class Form1 : Form
    {
        private String [,] agenda = new string[100,100];
        int i=0, Nombre =0, ApPaterno=1, ApMaterno=2, Número=3, Correo=4, Folio=5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            if(Rb_Guardar.Checked==true)
            {
                agenda[Nombre, i] = TxtBox_Nombre.Text;
                agenda[ApPaterno, i] = TxtBox_ApPaterno.Text;
                agenda[ApMaterno, i] = TxtBox_ApMaterno.Text;
                agenda[Número, i] = TxtBox_Número.Text;
                agenda[Correo, i] = TxtBox_Correo.Text;
                agenda[Folio, i] = (i + 1) + "";
                Lb_FolioAsignado.Text = agenda[Folio, i];

                MessageBox.Show("Nombre: " + agenda[Nombre, i] + " " + agenda[ApPaterno, i] + " " + agenda[ApMaterno, i] + 
                    "\nCorreo: " + agenda[Correo, i] + "\nNúmero: " + agenda[Número, i] + "\nFolio: " + agenda[Folio, i]);
                i++;
            }
            if (Rb_Imprimir.Checked==true)
            {
                for (int a=0; a < i; a++)
                {
                    MessageBox.Show("Nombre: " + agenda[Nombre, a] + " " + agenda[ApPaterno, a] + " " + agenda[ApMaterno, a] +
                        "\nCorreo: " + agenda[Correo, a] + "\nNúmero: " + agenda[Número, a] + "\nFolio: " + agenda[Folio, a]);
                }
            }
            if(Rb_Buscar.Checked==true && Rb_Dato.Checked==true)
            {
                int dato = int.Parse(TxtBox_Buscar.Text);
                for(int a = 0; a < i; a++)
                {
                    if (agenda [Folio,a] == dato + "")
                    {
                        MessageBox.Show("Nombre: " + agenda[Nombre, a] + " " + agenda[ApPaterno, a] + " " + agenda[ApMaterno, a] +
                            "\nCorreo: " + agenda[Correo, a] + "\nNúmero: " + agenda[Número, a] + "\nFolio: " + agenda[Folio, a]);
                    }
                }
            }
            if(Rb_Buscar.Checked==true && Rb_Posición.Checked==true)
            {
                int posición = int.Parse(TxtBox_Buscar.Text);
                if (posición < i)
                {
                     MessageBox.Show("Nombre: " + agenda[Nombre, posición] + " " + agenda[ApPaterno, posición] + " " + agenda[ApMaterno, posición] +
                        "\nCorreo: " + agenda[Correo, posición] + "\nNúmero: " + agenda[Número, posición] + "\nFolio: " + agenda[Folio, posición]);
                }
            }
            if( Rb_Eliminar.Checked==true && Rb_Dato.Checked==true)
            {
                int eliminar = int.Parse(TxtBox_Buscar.Text);
                for (int a = eliminar - 1; a < (i - 1); a++)
                {
                    agenda[Nombre, i] = agenda[Nombre , eliminar + 1];
                    agenda[ApPaterno, i] = agenda[ApPaterno, eliminar + 1];
                    agenda[ApMaterno, i] = agenda[ApMaterno, eliminar + 1];
                    agenda[Número, i] = agenda[Número, eliminar + 1];
                    agenda[Correo, i] = agenda[Correo, eliminar + 1];
                    agenda[Folio, i] = agenda[Folio, eliminar + 1];
                }
                i--;
            }
            if (Rb_Eliminar.Checked == true && Rb_Posición.Checked == true)
            {
                int pos = int.Parse(TxtBox_Buscar.Text);
                for (int b = pos - 1; b < (i - 1); b++)
                {
                    agenda[Nombre, i] = agenda[pos, i + 1];
                    agenda[ApPaterno, i] = agenda[pos, i + 1];
                    agenda[ApMaterno, i] = agenda[pos, i + 1];
                    agenda[Número, i] = agenda[pos, i + 1];
                    agenda[Correo, i] = agenda[pos, i + 1];
                    agenda[Folio, i] = agenda[pos, i + 1];
                }
                i--;
            }
        }
    }
}
