namespace ejemplo1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(180, 53);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(98, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(180, 91);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(98, 20);
            this.txt2.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(180, 130);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(284, 135);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 231);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblResultado;
    }
}

