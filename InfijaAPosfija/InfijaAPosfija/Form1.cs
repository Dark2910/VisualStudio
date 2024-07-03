using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace InfijaAPosfija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            A_notacion_polaca dato = new A_notacion_polaca();
            textBox2.Text = dato.ConvertirPosFija(textBox1.Text).ToString();

            if (radio_Resultado.Checked == true)
            {



            }

        }

      
           
    }


            
}

