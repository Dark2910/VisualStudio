namespace Agenda_dinamica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_ApP = new System.Windows.Forms.Label();
            this.Lb_ApM = new System.Windows.Forms.Label();
            this.Lb_Correo = new System.Windows.Forms.Label();
            this.Lb_Numero = new System.Windows.Forms.Label();
            this.TxtBox_Nombre = new System.Windows.Forms.TextBox();
            this.TxtBox_ApPaterno = new System.Windows.Forms.TextBox();
            this.TxtBox_ApMaterno = new System.Windows.Forms.TextBox();
            this.TxtBox_Telefono = new System.Windows.Forms.TextBox();
            this.TxtBox_Correo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Imprimir = new System.Windows.Forms.RadioButton();
            this.Rb_Guardar = new System.Windows.Forms.RadioButton();
            this.Button_Aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Titulo
            // 
            this.Lb_Titulo.AutoSize = true;
            this.Lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Titulo.Location = new System.Drawing.Point(223, 21);
            this.Lb_Titulo.Name = "Lb_Titulo";
            this.Lb_Titulo.Size = new System.Drawing.Size(100, 29);
            this.Lb_Titulo.TabIndex = 0;
            this.Lb_Titulo.Text = "Agenda";
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Location = new System.Drawing.Point(37, 108);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(62, 17);
            this.Lb_Nombre.TabIndex = 1;
            this.Lb_Nombre.Text = "Nombre:";
            // 
            // Lb_ApP
            // 
            this.Lb_ApP.AutoSize = true;
            this.Lb_ApP.Location = new System.Drawing.Point(37, 164);
            this.Lb_ApP.Name = "Lb_ApP";
            this.Lb_ApP.Size = new System.Drawing.Size(116, 17);
            this.Lb_ApP.TabIndex = 2;
            this.Lb_ApP.Text = "Apellido Paterno:";
            // 
            // Lb_ApM
            // 
            this.Lb_ApM.AutoSize = true;
            this.Lb_ApM.Location = new System.Drawing.Point(37, 220);
            this.Lb_ApM.Name = "Lb_ApM";
            this.Lb_ApM.Size = new System.Drawing.Size(118, 17);
            this.Lb_ApM.TabIndex = 3;
            this.Lb_ApM.Text = "Apellido Materno:";
            // 
            // Lb_Correo
            // 
            this.Lb_Correo.AutoSize = true;
            this.Lb_Correo.Location = new System.Drawing.Point(37, 342);
            this.Lb_Correo.Name = "Lb_Correo";
            this.Lb_Correo.Size = new System.Drawing.Size(55, 17);
            this.Lb_Correo.TabIndex = 4;
            this.Lb_Correo.Text = "Correo:";
            // 
            // Lb_Numero
            // 
            this.Lb_Numero.AutoSize = true;
            this.Lb_Numero.Location = new System.Drawing.Point(37, 282);
            this.Lb_Numero.Name = "Lb_Numero";
            this.Lb_Numero.Size = new System.Drawing.Size(127, 17);
            this.Lb_Numero.TabIndex = 5;
            this.Lb_Numero.Text = "Número teléfonico:";
            // 
            // TxtBox_Nombre
            // 
            this.TxtBox_Nombre.Location = new System.Drawing.Point(188, 102);
            this.TxtBox_Nombre.Name = "TxtBox_Nombre";
            this.TxtBox_Nombre.Size = new System.Drawing.Size(149, 22);
            this.TxtBox_Nombre.TabIndex = 6;
            // 
            // TxtBox_ApPaterno
            // 
            this.TxtBox_ApPaterno.Location = new System.Drawing.Point(188, 158);
            this.TxtBox_ApPaterno.Name = "TxtBox_ApPaterno";
            this.TxtBox_ApPaterno.Size = new System.Drawing.Size(149, 22);
            this.TxtBox_ApPaterno.TabIndex = 7;
            // 
            // TxtBox_ApMaterno
            // 
            this.TxtBox_ApMaterno.Location = new System.Drawing.Point(188, 215);
            this.TxtBox_ApMaterno.Name = "TxtBox_ApMaterno";
            this.TxtBox_ApMaterno.Size = new System.Drawing.Size(149, 22);
            this.TxtBox_ApMaterno.TabIndex = 8;
            // 
            // TxtBox_Telefono
            // 
            this.TxtBox_Telefono.Location = new System.Drawing.Point(188, 277);
            this.TxtBox_Telefono.Name = "TxtBox_Telefono";
            this.TxtBox_Telefono.Size = new System.Drawing.Size(149, 22);
            this.TxtBox_Telefono.TabIndex = 9;
            // 
            // TxtBox_Correo
            // 
            this.TxtBox_Correo.Location = new System.Drawing.Point(188, 337);
            this.TxtBox_Correo.Name = "TxtBox_Correo";
            this.TxtBox_Correo.Size = new System.Drawing.Size(149, 22);
            this.TxtBox_Correo.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Imprimir);
            this.groupBox1.Controls.Add(this.Rb_Guardar);
            this.groupBox1.Location = new System.Drawing.Point(411, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Rb_Imprimir
            // 
            this.Rb_Imprimir.AutoSize = true;
            this.Rb_Imprimir.Location = new System.Drawing.Point(130, 22);
            this.Rb_Imprimir.Name = "Rb_Imprimir";
            this.Rb_Imprimir.Size = new System.Drawing.Size(78, 21);
            this.Rb_Imprimir.TabIndex = 1;
            this.Rb_Imprimir.TabStop = true;
            this.Rb_Imprimir.Text = "Imprimir";
            this.Rb_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Rb_Guardar
            // 
            this.Rb_Guardar.AutoSize = true;
            this.Rb_Guardar.Location = new System.Drawing.Point(7, 22);
            this.Rb_Guardar.Name = "Rb_Guardar";
            this.Rb_Guardar.Size = new System.Drawing.Size(82, 21);
            this.Rb_Guardar.TabIndex = 0;
            this.Rb_Guardar.TabStop = true;
            this.Rb_Guardar.Text = "Guardar";
            this.Rb_Guardar.UseVisualStyleBackColor = true;
            // 
            // Button_Aceptar
            // 
            this.Button_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Aceptar.Location = new System.Drawing.Point(411, 317);
            this.Button_Aceptar.Name = "Button_Aceptar";
            this.Button_Aceptar.Size = new System.Drawing.Size(89, 42);
            this.Button_Aceptar.TabIndex = 13;
            this.Button_Aceptar.Text = "Aceptar";
            this.Button_Aceptar.UseVisualStyleBackColor = true;
            this.Button_Aceptar.Click += new System.EventHandler(this.Button_Aceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 434);
            this.Controls.Add(this.Button_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtBox_Correo);
            this.Controls.Add(this.TxtBox_Telefono);
            this.Controls.Add(this.TxtBox_ApMaterno);
            this.Controls.Add(this.TxtBox_ApPaterno);
            this.Controls.Add(this.TxtBox_Nombre);
            this.Controls.Add(this.Lb_Numero);
            this.Controls.Add(this.Lb_Correo);
            this.Controls.Add(this.Lb_ApM);
            this.Controls.Add(this.Lb_ApP);
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.Lb_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Titulo;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_ApP;
        private System.Windows.Forms.Label Lb_ApM;
        private System.Windows.Forms.Label Lb_Correo;
        private System.Windows.Forms.Label Lb_Numero;
        private System.Windows.Forms.TextBox TxtBox_Nombre;
        private System.Windows.Forms.TextBox TxtBox_ApPaterno;
        private System.Windows.Forms.TextBox TxtBox_ApMaterno;
        private System.Windows.Forms.TextBox TxtBox_Telefono;
        private System.Windows.Forms.TextBox TxtBox_Correo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Imprimir;
        private System.Windows.Forms.RadioButton Rb_Guardar;
        private System.Windows.Forms.Button Button_Aceptar;
    }
}

