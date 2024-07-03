namespace Avance_de_proyecto_2._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_SerieNumerica = new System.Windows.Forms.TextBox();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_NotacionPolaca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Cola = new System.Windows.Forms.Button();
            this.Button_Pila = new System.Windows.Forms.Button();
            this.TxtBox_Resultado = new System.Windows.Forms.TextBox();
            this.Lb_Resultado = new System.Windows.Forms.Label();
            this.Button_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie numerica";
            // 
            // TxtBox_SerieNumerica
            // 
            this.TxtBox_SerieNumerica.Location = new System.Drawing.Point(198, 44);
            this.TxtBox_SerieNumerica.Name = "TxtBox_SerieNumerica";
            this.TxtBox_SerieNumerica.Size = new System.Drawing.Size(217, 22);
            this.TxtBox_SerieNumerica.TabIndex = 1;
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(70, 227);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 3;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notacion polaca";
            // 
            // TxtBox_NotacionPolaca
            // 
            this.TxtBox_NotacionPolaca.Location = new System.Drawing.Point(198, 103);
            this.TxtBox_NotacionPolaca.Name = "TxtBox_NotacionPolaca";
            this.TxtBox_NotacionPolaca.Size = new System.Drawing.Size(217, 22);
            this.TxtBox_NotacionPolaca.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Cola);
            this.groupBox1.Controls.Add(this.Button_Pila);
            this.groupBox1.Location = new System.Drawing.Point(273, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TDA";
            // 
            // Button_Cola
            // 
            this.Button_Cola.Location = new System.Drawing.Point(33, 67);
            this.Button_Cola.Name = "Button_Cola";
            this.Button_Cola.Size = new System.Drawing.Size(75, 23);
            this.Button_Cola.TabIndex = 3;
            this.Button_Cola.Text = "Cola";
            this.Button_Cola.UseVisualStyleBackColor = true;
            this.Button_Cola.Click += new System.EventHandler(this.Button_Cola_Click);
            // 
            // Button_Pila
            // 
            this.Button_Pila.Location = new System.Drawing.Point(33, 21);
            this.Button_Pila.Name = "Button_Pila";
            this.Button_Pila.Size = new System.Drawing.Size(75, 23);
            this.Button_Pila.TabIndex = 2;
            this.Button_Pila.Text = "Pila";
            this.Button_Pila.UseVisualStyleBackColor = true;
            this.Button_Pila.Click += new System.EventHandler(this.Button_Pila_Click);
            // 
            // TxtBox_Resultado
            // 
            this.TxtBox_Resultado.Location = new System.Drawing.Point(198, 157);
            this.TxtBox_Resultado.Name = "TxtBox_Resultado";
            this.TxtBox_Resultado.Size = new System.Drawing.Size(217, 22);
            this.TxtBox_Resultado.TabIndex = 8;
            // 
            // Lb_Resultado
            // 
            this.Lb_Resultado.AutoSize = true;
            this.Lb_Resultado.Location = new System.Drawing.Point(67, 162);
            this.Lb_Resultado.Name = "Lb_Resultado";
            this.Lb_Resultado.Size = new System.Drawing.Size(72, 17);
            this.Lb_Resultado.TabIndex = 9;
            this.Lb_Resultado.Text = "Resultado";
            // 
            // Button_Limpiar
            // 
            this.Button_Limpiar.Location = new System.Drawing.Point(70, 267);
            this.Button_Limpiar.Name = "Button_Limpiar";
            this.Button_Limpiar.Size = new System.Drawing.Size(75, 34);
            this.Button_Limpiar.TabIndex = 10;
            this.Button_Limpiar.Text = "Limpiar";
            this.Button_Limpiar.UseVisualStyleBackColor = true;
            this.Button_Limpiar.Click += new System.EventHandler(this.Button_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 342);
            this.Controls.Add(this.Button_Limpiar);
            this.Controls.Add(this.Lb_Resultado);
            this.Controls.Add(this.TxtBox_Resultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtBox_NotacionPolaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.TxtBox_SerieNumerica);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_SerieNumerica;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBox_NotacionPolaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Cola;
        private System.Windows.Forms.Button Button_Pila;
        private System.Windows.Forms.TextBox TxtBox_Resultado;
        private System.Windows.Forms.Label Lb_Resultado;
        private System.Windows.Forms.Button Button_Limpiar;
    }
}

