namespace VistaPrincipal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblExplicacionPrincipal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBoxPrincipalFiltros = new System.Windows.Forms.GroupBox();
            this.btnFiltroReset = new System.Windows.Forms.Button();
            this.btnFiltroAceptar = new System.Windows.Forms.Button();
            this.groupBoxPrincFiltroPrecio = new System.Windows.Forms.GroupBox();
            this.txtFiltroRangoMax = new System.Windows.Forms.TextBox();
            this.txtFiltroRangoMin = new System.Windows.Forms.TextBox();
            this.lblFiltroRangoMax = new System.Windows.Forms.Label();
            this.lblFiltroRangoMin = new System.Windows.Forms.Label();
            this.groupBoxPrincFiltroParam = new System.Windows.Forms.GroupBox();
            this.cboFiltroParam = new System.Windows.Forms.ComboBox();
            this.lblParamValor = new System.Windows.Forms.Label();
            this.txtFiltroParam = new System.Windows.Forms.TextBox();
            this.lblFiltroParamCampo = new System.Windows.Forms.Label();
            this.groupBoxPrincFiltroTipo = new System.Windows.Forms.GroupBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cboFiltroMarca = new System.Windows.Forms.ComboBox();
            this.cboFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBoxPrincipalFiltros.SuspendLayout();
            this.groupBoxPrincFiltroPrecio.SuspendLayout();
            this.groupBoxPrincFiltroParam.SuspendLayout();
            this.groupBoxPrincFiltroTipo.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(11, 47);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(441, 227);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulos_MouseDoubleClick);
            // 
            // lblExplicacionPrincipal
            // 
            this.lblExplicacionPrincipal.AutoSize = true;
            this.lblExplicacionPrincipal.Location = new System.Drawing.Point(12, 28);
            this.lblExplicacionPrincipal.Name = "lblExplicacionPrincipal";
            this.lblExplicacionPrincipal.Size = new System.Drawing.Size(241, 13);
            this.lblExplicacionPrincipal.TabIndex = 1;
            this.lblExplicacionPrincipal.Text = "Doble click en el articulo para consultar el detalle.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 293);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(197, 293);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(377, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBoxPrincipalFiltros
            // 
            this.groupBoxPrincipalFiltros.Controls.Add(this.btnFiltroReset);
            this.groupBoxPrincipalFiltros.Controls.Add(this.btnFiltroAceptar);
            this.groupBoxPrincipalFiltros.Controls.Add(this.groupBoxPrincFiltroPrecio);
            this.groupBoxPrincipalFiltros.Controls.Add(this.groupBoxPrincFiltroParam);
            this.groupBoxPrincipalFiltros.Controls.Add(this.groupBoxPrincFiltroTipo);
            this.groupBoxPrincipalFiltros.Location = new System.Drawing.Point(473, 24);
            this.groupBoxPrincipalFiltros.Name = "groupBoxPrincipalFiltros";
            this.groupBoxPrincipalFiltros.Size = new System.Drawing.Size(319, 292);
            this.groupBoxPrincipalFiltros.TabIndex = 5;
            this.groupBoxPrincipalFiltros.TabStop = false;
            this.groupBoxPrincipalFiltros.Text = "Filtros";
            // 
            // btnFiltroReset
            // 
            this.btnFiltroReset.Location = new System.Drawing.Point(232, 169);
            this.btnFiltroReset.Name = "btnFiltroReset";
            this.btnFiltroReset.Size = new System.Drawing.Size(75, 44);
            this.btnFiltroReset.TabIndex = 4;
            this.btnFiltroReset.Text = "Borrar filtros";
            this.btnFiltroReset.UseVisualStyleBackColor = true;
            this.btnFiltroReset.Click += new System.EventHandler(this.btnFiltroReset_Click);
            // 
            // btnFiltroAceptar
            // 
            this.btnFiltroAceptar.Location = new System.Drawing.Point(232, 111);
            this.btnFiltroAceptar.Name = "btnFiltroAceptar";
            this.btnFiltroAceptar.Size = new System.Drawing.Size(75, 42);
            this.btnFiltroAceptar.TabIndex = 3;
            this.btnFiltroAceptar.Text = "Filtrar";
            this.btnFiltroAceptar.UseVisualStyleBackColor = true;
            this.btnFiltroAceptar.Click += new System.EventHandler(this.btnFiltroAceptar_Click);
            // 
            // groupBoxPrincFiltroPrecio
            // 
            this.groupBoxPrincFiltroPrecio.Controls.Add(this.txtFiltroRangoMax);
            this.groupBoxPrincFiltroPrecio.Controls.Add(this.txtFiltroRangoMin);
            this.groupBoxPrincFiltroPrecio.Controls.Add(this.lblFiltroRangoMax);
            this.groupBoxPrincFiltroPrecio.Controls.Add(this.lblFiltroRangoMin);
            this.groupBoxPrincFiltroPrecio.Location = new System.Drawing.Point(7, 211);
            this.groupBoxPrincFiltroPrecio.Name = "groupBoxPrincFiltroPrecio";
            this.groupBoxPrincFiltroPrecio.Size = new System.Drawing.Size(204, 75);
            this.groupBoxPrincFiltroPrecio.TabIndex = 2;
            this.groupBoxPrincFiltroPrecio.TabStop = false;
            this.groupBoxPrincFiltroPrecio.Text = "Rango de precios";
            // 
            // txtFiltroRangoMax
            // 
            this.txtFiltroRangoMax.Location = new System.Drawing.Point(69, 48);
            this.txtFiltroRangoMax.Name = "txtFiltroRangoMax";
            this.txtFiltroRangoMax.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroRangoMax.TabIndex = 3;
            // 
            // txtFiltroRangoMin
            // 
            this.txtFiltroRangoMin.Location = new System.Drawing.Point(69, 23);
            this.txtFiltroRangoMin.Name = "txtFiltroRangoMin";
            this.txtFiltroRangoMin.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroRangoMin.TabIndex = 2;
            // 
            // lblFiltroRangoMax
            // 
            this.lblFiltroRangoMax.AutoSize = true;
            this.lblFiltroRangoMax.Location = new System.Drawing.Point(17, 55);
            this.lblFiltroRangoMax.Name = "lblFiltroRangoMax";
            this.lblFiltroRangoMax.Size = new System.Drawing.Size(46, 13);
            this.lblFiltroRangoMax.TabIndex = 1;
            this.lblFiltroRangoMax.Text = "Máximo:";
            // 
            // lblFiltroRangoMin
            // 
            this.lblFiltroRangoMin.AutoSize = true;
            this.lblFiltroRangoMin.Location = new System.Drawing.Point(34, 26);
            this.lblFiltroRangoMin.Name = "lblFiltroRangoMin";
            this.lblFiltroRangoMin.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroRangoMin.TabIndex = 0;
            this.lblFiltroRangoMin.Text = "Mín:";
            // 
            // groupBoxPrincFiltroParam
            // 
            this.groupBoxPrincFiltroParam.Controls.Add(this.cboFiltroParam);
            this.groupBoxPrincFiltroParam.Controls.Add(this.lblParamValor);
            this.groupBoxPrincFiltroParam.Controls.Add(this.txtFiltroParam);
            this.groupBoxPrincFiltroParam.Controls.Add(this.lblFiltroParamCampo);
            this.groupBoxPrincFiltroParam.Location = new System.Drawing.Point(7, 125);
            this.groupBoxPrincFiltroParam.Name = "groupBoxPrincFiltroParam";
            this.groupBoxPrincFiltroParam.Size = new System.Drawing.Size(204, 79);
            this.groupBoxPrincFiltroParam.TabIndex = 1;
            this.groupBoxPrincFiltroParam.TabStop = false;
            this.groupBoxPrincFiltroParam.Text = "Parametros";
            // 
            // cboFiltroParam
            // 
            this.cboFiltroParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroParam.FormattingEnabled = true;
            this.cboFiltroParam.Location = new System.Drawing.Point(69, 20);
            this.cboFiltroParam.Name = "cboFiltroParam";
            this.cboFiltroParam.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroParam.TabIndex = 3;
            // 
            // lblParamValor
            // 
            this.lblParamValor.AutoSize = true;
            this.lblParamValor.Location = new System.Drawing.Point(11, 47);
            this.lblParamValor.Name = "lblParamValor";
            this.lblParamValor.Size = new System.Drawing.Size(52, 13);
            this.lblParamValor.TabIndex = 2;
            this.lblParamValor.Text = "Contiene:";
            // 
            // txtFiltroParam
            // 
            this.txtFiltroParam.Location = new System.Drawing.Point(69, 44);
            this.txtFiltroParam.Name = "txtFiltroParam";
            this.txtFiltroParam.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroParam.TabIndex = 1;
            // 
            // lblFiltroParamCampo
            // 
            this.lblFiltroParamCampo.AutoSize = true;
            this.lblFiltroParamCampo.Location = new System.Drawing.Point(20, 25);
            this.lblFiltroParamCampo.Name = "lblFiltroParamCampo";
            this.lblFiltroParamCampo.Size = new System.Drawing.Size(43, 13);
            this.lblFiltroParamCampo.TabIndex = 0;
            this.lblFiltroParamCampo.Text = "Campo:";
            // 
            // groupBoxPrincFiltroTipo
            // 
            this.groupBoxPrincFiltroTipo.Controls.Add(this.lblFiltroMarca);
            this.groupBoxPrincFiltroTipo.Controls.Add(this.lblFiltroCategoria);
            this.groupBoxPrincFiltroTipo.Controls.Add(this.cboFiltroMarca);
            this.groupBoxPrincFiltroTipo.Controls.Add(this.cboFiltroCategoria);
            this.groupBoxPrincFiltroTipo.Location = new System.Drawing.Point(7, 19);
            this.groupBoxPrincFiltroTipo.Name = "groupBoxPrincFiltroTipo";
            this.groupBoxPrincFiltroTipo.Size = new System.Drawing.Size(204, 100);
            this.groupBoxPrincFiltroTipo.TabIndex = 0;
            this.groupBoxPrincFiltroTipo.TabStop = false;
            this.groupBoxPrincFiltroTipo.Text = "Marca / Categoria";
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(23, 63);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(40, 13);
            this.lblFiltroMarca.TabIndex = 3;
            this.lblFiltroMarca.Text = "Marca:";
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(6, 27);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblFiltroCategoria.TabIndex = 2;
            this.lblFiltroCategoria.Text = "Categoría:";
            // 
            // cboFiltroMarca
            // 
            this.cboFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroMarca.FormattingEnabled = true;
            this.cboFiltroMarca.Location = new System.Drawing.Point(69, 60);
            this.cboFiltroMarca.Name = "cboFiltroMarca";
            this.cboFiltroMarca.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroMarca.TabIndex = 1;
            // 
            // cboFiltroCategoria
            // 
            this.cboFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoria.FormattingEnabled = true;
            this.cboFiltroCategoria.Location = new System.Drawing.Point(69, 24);
            this.cboFiltroCategoria.Name = "cboFiltroCategoria";
            this.cboFiltroCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroCategoria.TabIndex = 0;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(756, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(58, 321);
            this.menuPrincipal.TabIndex = 6;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.soporteToolStripMenuItem.Text = "About";
            this.soporteToolStripMenuItem.Click += new System.EventHandler(this.soporteToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 321);
            this.Controls.Add(this.groupBoxPrincipalFiltros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblExplicacionPrincipal);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximumSize = new System.Drawing.Size(830, 360);
            this.MinimumSize = new System.Drawing.Size(830, 360);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBoxPrincipalFiltros.ResumeLayout(false);
            this.groupBoxPrincFiltroPrecio.ResumeLayout(false);
            this.groupBoxPrincFiltroPrecio.PerformLayout();
            this.groupBoxPrincFiltroParam.ResumeLayout(false);
            this.groupBoxPrincFiltroParam.PerformLayout();
            this.groupBoxPrincFiltroTipo.ResumeLayout(false);
            this.groupBoxPrincFiltroTipo.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblExplicacionPrincipal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBoxPrincipalFiltros;
        private System.Windows.Forms.GroupBox groupBoxPrincFiltroTipo;
        private System.Windows.Forms.GroupBox groupBoxPrincFiltroPrecio;
        private System.Windows.Forms.GroupBox groupBoxPrincFiltroParam;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox cboFiltroMarca;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private System.Windows.Forms.ComboBox cboFiltroParam;
        private System.Windows.Forms.Label lblParamValor;
        private System.Windows.Forms.TextBox txtFiltroParam;
        private System.Windows.Forms.Label lblFiltroParamCampo;
        private System.Windows.Forms.Label lblFiltroRangoMax;
        private System.Windows.Forms.Label lblFiltroRangoMin;
        private System.Windows.Forms.Button btnFiltroReset;
        private System.Windows.Forms.Button btnFiltroAceptar;
        private System.Windows.Forms.TextBox txtFiltroRangoMax;
        private System.Windows.Forms.TextBox txtFiltroRangoMin;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
    }
}

