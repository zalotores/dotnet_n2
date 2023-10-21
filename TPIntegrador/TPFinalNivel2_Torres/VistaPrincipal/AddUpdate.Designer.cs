namespace VistaPrincipal
{
    partial class frmAddUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdate));
            this.lblAddCodigo = new System.Windows.Forms.Label();
            this.lblAddNombre = new System.Windows.Forms.Label();
            this.lblAddDescripcion = new System.Windows.Forms.Label();
            this.lblAddMarca = new System.Windows.Forms.Label();
            this.lblAddCat = new System.Windows.Forms.Label();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.lblAddPrecio = new System.Windows.Forms.Label();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.txtAddNombre = new System.Windows.Forms.TextBox();
            this.txtAddDescripcion = new System.Windows.Forms.TextBox();
            this.txtAddImagen = new System.Windows.Forms.TextBox();
            this.txtAddPrecio = new System.Windows.Forms.TextBox();
            this.picboxAddImagen = new System.Windows.Forms.PictureBox();
            this.btnAddCancelar = new System.Windows.Forms.Button();
            this.btnAddAceptar = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddArchivo = new System.Windows.Forms.Button();
            this.cboAddCategoria = new System.Windows.Forms.ComboBox();
            this.cboAddMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAddImagen)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCodigo
            // 
            this.lblAddCodigo.AutoSize = true;
            this.lblAddCodigo.Location = new System.Drawing.Point(53, 24);
            this.lblAddCodigo.Name = "lblAddCodigo";
            this.lblAddCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblAddCodigo.TabIndex = 0;
            this.lblAddCodigo.Text = "Código:";
            // 
            // lblAddNombre
            // 
            this.lblAddNombre.AutoSize = true;
            this.lblAddNombre.Location = new System.Drawing.Point(49, 55);
            this.lblAddNombre.Name = "lblAddNombre";
            this.lblAddNombre.Size = new System.Drawing.Size(47, 13);
            this.lblAddNombre.TabIndex = 1;
            this.lblAddNombre.Text = "Nombre:";
            // 
            // lblAddDescripcion
            // 
            this.lblAddDescripcion.AutoSize = true;
            this.lblAddDescripcion.Location = new System.Drawing.Point(30, 84);
            this.lblAddDescripcion.Name = "lblAddDescripcion";
            this.lblAddDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblAddDescripcion.TabIndex = 2;
            this.lblAddDescripcion.Text = "Descripción:";
            // 
            // lblAddMarca
            // 
            this.lblAddMarca.AutoSize = true;
            this.lblAddMarca.Location = new System.Drawing.Point(56, 154);
            this.lblAddMarca.Name = "lblAddMarca";
            this.lblAddMarca.Size = new System.Drawing.Size(40, 13);
            this.lblAddMarca.TabIndex = 3;
            this.lblAddMarca.Text = "Marca:";
            // 
            // lblAddCat
            // 
            this.lblAddCat.AutoSize = true;
            this.lblAddCat.Location = new System.Drawing.Point(39, 182);
            this.lblAddCat.Name = "lblAddCat";
            this.lblAddCat.Size = new System.Drawing.Size(57, 13);
            this.lblAddCat.TabIndex = 4;
            this.lblAddCat.Text = "Categoría:";
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Location = new System.Drawing.Point(11, 237);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(85, 13);
            this.lblAddImage.TabIndex = 5;
            this.lblAddImage.Text = "URL de Imagen:";
            // 
            // lblAddPrecio
            // 
            this.lblAddPrecio.AutoSize = true;
            this.lblAddPrecio.Location = new System.Drawing.Point(56, 210);
            this.lblAddPrecio.Name = "lblAddPrecio";
            this.lblAddPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblAddPrecio.TabIndex = 6;
            this.lblAddPrecio.Text = "Precio:";
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Location = new System.Drawing.Point(102, 21);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(138, 20);
            this.txtAddCodigo.TabIndex = 0;
            // 
            // txtAddNombre
            // 
            this.txtAddNombre.Location = new System.Drawing.Point(102, 52);
            this.txtAddNombre.Name = "txtAddNombre";
            this.txtAddNombre.Size = new System.Drawing.Size(138, 20);
            this.txtAddNombre.TabIndex = 1;
            // 
            // txtAddDescripcion
            // 
            this.txtAddDescripcion.Location = new System.Drawing.Point(102, 81);
            this.txtAddDescripcion.Multiline = true;
            this.txtAddDescripcion.Name = "txtAddDescripcion";
            this.txtAddDescripcion.Size = new System.Drawing.Size(138, 66);
            this.txtAddDescripcion.TabIndex = 2;
            // 
            // txtAddImagen
            // 
            this.txtAddImagen.Location = new System.Drawing.Point(102, 234);
            this.txtAddImagen.Name = "txtAddImagen";
            this.txtAddImagen.Size = new System.Drawing.Size(137, 20);
            this.txtAddImagen.TabIndex = 6;
            this.txtAddImagen.Leave += new System.EventHandler(this.txtAddImagen_Leave);
            // 
            // txtAddPrecio
            // 
            this.txtAddPrecio.Location = new System.Drawing.Point(102, 208);
            this.txtAddPrecio.Name = "txtAddPrecio";
            this.txtAddPrecio.Size = new System.Drawing.Size(138, 20);
            this.txtAddPrecio.TabIndex = 5;
            // 
            // picboxAddImagen
            // 
            this.picboxAddImagen.Location = new System.Drawing.Point(246, 24);
            this.picboxAddImagen.Name = "picboxAddImagen";
            this.picboxAddImagen.Size = new System.Drawing.Size(218, 227);
            this.picboxAddImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAddImagen.TabIndex = 14;
            this.picboxAddImagen.TabStop = false;
            // 
            // btnAddCancelar
            // 
            this.btnAddCancelar.Location = new System.Drawing.Point(157, 326);
            this.btnAddCancelar.Name = "btnAddCancelar";
            this.btnAddCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancelar.TabIndex = 1;
            this.btnAddCancelar.Text = "Cancelar";
            this.btnAddCancelar.UseVisualStyleBackColor = true;
            this.btnAddCancelar.Click += new System.EventHandler(this.btnAddCancelar_Click);
            // 
            // btnAddAceptar
            // 
            this.btnAddAceptar.Location = new System.Drawing.Point(44, 326);
            this.btnAddAceptar.Name = "btnAddAceptar";
            this.btnAddAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAddAceptar.TabIndex = 0;
            this.btnAddAceptar.Text = "Aceptar";
            this.btnAddAceptar.UseVisualStyleBackColor = true;
            this.btnAddAceptar.Click += new System.EventHandler(this.btnAddAceptar_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.btnAddArchivo);
            this.groupBoxAdd.Controls.Add(this.cboAddCategoria);
            this.groupBoxAdd.Controls.Add(this.cboAddMarca);
            this.groupBoxAdd.Controls.Add(this.lblAddCodigo);
            this.groupBoxAdd.Controls.Add(this.lblAddNombre);
            this.groupBoxAdd.Controls.Add(this.lblAddDescripcion);
            this.groupBoxAdd.Controls.Add(this.picboxAddImagen);
            this.groupBoxAdd.Controls.Add(this.lblAddMarca);
            this.groupBoxAdd.Controls.Add(this.txtAddPrecio);
            this.groupBoxAdd.Controls.Add(this.lblAddCat);
            this.groupBoxAdd.Controls.Add(this.txtAddImagen);
            this.groupBoxAdd.Controls.Add(this.lblAddImage);
            this.groupBoxAdd.Controls.Add(this.lblAddPrecio);
            this.groupBoxAdd.Controls.Add(this.txtAddCodigo);
            this.groupBoxAdd.Controls.Add(this.txtAddDescripcion);
            this.groupBoxAdd.Controls.Add(this.txtAddNombre);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(470, 308);
            this.groupBoxAdd.TabIndex = 17;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "O elija ubicacion de archivo:";
            // 
            // btnAddArchivo
            // 
            this.btnAddArchivo.Location = new System.Drawing.Point(153, 264);
            this.btnAddArchivo.Name = "btnAddArchivo";
            this.btnAddArchivo.Size = new System.Drawing.Size(82, 23);
            this.btnAddArchivo.TabIndex = 7;
            this.btnAddArchivo.Text = "Cargar desde ";
            this.btnAddArchivo.UseVisualStyleBackColor = true;
            this.btnAddArchivo.Click += new System.EventHandler(this.btnAddArchivo_Click);
            // 
            // cboAddCategoria
            // 
            this.cboAddCategoria.FormattingEnabled = true;
            this.cboAddCategoria.Location = new System.Drawing.Point(102, 181);
            this.cboAddCategoria.Name = "cboAddCategoria";
            this.cboAddCategoria.Size = new System.Drawing.Size(138, 21);
            this.cboAddCategoria.TabIndex = 4;
            // 
            // cboAddMarca
            // 
            this.cboAddMarca.FormattingEnabled = true;
            this.cboAddMarca.Location = new System.Drawing.Point(102, 154);
            this.cboAddMarca.Name = "cboAddMarca";
            this.cboAddMarca.Size = new System.Drawing.Size(138, 21);
            this.cboAddMarca.TabIndex = 3;
            // 
            // frmAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.btnAddAceptar);
            this.Controls.Add(this.btnAddCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 400);
            this.MinimumSize = new System.Drawing.Size(510, 400);
            this.Name = "frmAddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAddUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAddImagen)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddCodigo;
        private System.Windows.Forms.Label lblAddNombre;
        private System.Windows.Forms.Label lblAddDescripcion;
        private System.Windows.Forms.Label lblAddMarca;
        private System.Windows.Forms.Label lblAddCat;
        private System.Windows.Forms.Label lblAddImage;
        private System.Windows.Forms.Label lblAddPrecio;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.TextBox txtAddNombre;
        private System.Windows.Forms.TextBox txtAddDescripcion;
        private System.Windows.Forms.TextBox txtAddImagen;
        private System.Windows.Forms.TextBox txtAddPrecio;
        private System.Windows.Forms.PictureBox picboxAddImagen;
        private System.Windows.Forms.Button btnAddCancelar;
        private System.Windows.Forms.Button btnAddAceptar;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.ComboBox cboAddCategoria;
        private System.Windows.Forms.ComboBox cboAddMarca;
        private System.Windows.Forms.Button btnAddArchivo;
        private System.Windows.Forms.Label label1;
    }
}