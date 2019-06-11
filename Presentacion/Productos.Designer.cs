namespace Presentacion
{
    partial class Productos
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
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbBusTipo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.lblBusCategoria = new System.Windows.Forms.Label();
            this.lblBusNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.btnTGuardar = new System.Windows.Forms.Button();
            this.btnTEliminar = new System.Windows.Forms.Button();
            this.btnTModificar = new System.Windows.Forms.Button();
            this.btnTNuevo = new System.Windows.Forms.Button();
            this.lblTNombre = new System.Windows.Forms.Label();
            this.txtTNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblTipos = new System.Windows.Forms.DataGridView();
            this.gbBusTipo = new System.Windows.Forms.GroupBox();
            this.btnTRest = new System.Windows.Forms.Button();
            this.btnTBuscar = new System.Windows.Forms.Button();
            this.txtBusTNombre = new System.Windows.Forms.TextBox();
            this.lblBusTNombre = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipos)).BeginInit();
            this.gbBusTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProductos
            // 
            this.tblProductos.AllowUserToAddRows = false;
            this.tblProductos.AllowUserToDeleteRows = false;
            this.tblProductos.AllowUserToResizeColumns = false;
            this.tblProductos.AllowUserToResizeRows = false;
            this.tblProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripción,
            this.Marca,
            this.Stock,
            this.Precio,
            this.TipoProducto});
            this.tblProductos.Location = new System.Drawing.Point(4, 4);
            this.tblProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tblProductos.MultiSelect = false;
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductos.Size = new System.Drawing.Size(905, 398);
            this.tblProductos.TabIndex = 0;
            this.tblProductos.SelectionChanged += new System.EventHandler(this.tblProductos_SelectionChanged);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnReset);
            this.gbBuscar.Controls.Add(this.cbBusTipo);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtBusNombre);
            this.gbBuscar.Controls.Add(this.lblBusCategoria);
            this.gbBuscar.Controls.Add(this.lblBusNombre);
            this.gbBuscar.Location = new System.Drawing.Point(16, 15);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Size = new System.Drawing.Size(913, 69);
            this.gbBuscar.TabIndex = 1;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar producto";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(801, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbBusTipo
            // 
            this.cbBusTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusTipo.FormattingEnabled = true;
            this.cbBusTipo.Location = new System.Drawing.Point(445, 26);
            this.cbBusTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbBusTipo.Name = "cbBusTipo";
            this.cbBusTipo.Size = new System.Drawing.Size(239, 24);
            this.cbBusTipo.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(693, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(75, 25);
            this.txtBusNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(309, 22);
            this.txtBusNombre.TabIndex = 2;
            // 
            // lblBusCategoria
            // 
            this.lblBusCategoria.AutoSize = true;
            this.lblBusCategoria.Location = new System.Drawing.Point(400, 30);
            this.lblBusCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusCategoria.Name = "lblBusCategoria";
            this.lblBusCategoria.Size = new System.Drawing.Size(36, 17);
            this.lblBusCategoria.TabIndex = 3;
            this.lblBusCategoria.Text = "Tipo";
            // 
            // lblBusNombre
            // 
            this.lblBusNombre.AutoSize = true;
            this.lblBusNombre.Location = new System.Drawing.Point(8, 28);
            this.lblBusNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusNombre.Name = "lblBusNombre";
            this.lblBusNombre.Size = new System.Drawing.Size(58, 17);
            this.lblBusNombre.TabIndex = 1;
            this.lblBusNombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblProductos);
            this.panel1.Location = new System.Drawing.Point(16, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 406);
            this.panel1.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(100, 57);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(312, 22);
            this.txtStock.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(100, 181);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(312, 148);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(100, 89);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(312, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 185);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 28);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(8, 60);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(8, 92);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 153);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tipo";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.lblMarca);
            this.gbProducto.Controls.Add(this.txtMarca);
            this.gbProducto.Controls.Add(this.btnGuardarNuevo);
            this.gbProducto.Controls.Add(this.btnEliminar);
            this.gbProducto.Controls.Add(this.btnModificar);
            this.gbProducto.Controls.Add(this.btnNuevo);
            this.gbProducto.Controls.Add(this.cbTipo);
            this.gbProducto.Controls.Add(this.lblStock);
            this.gbProducto.Controls.Add(this.txtDescripcion);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.label11);
            this.gbProducto.Controls.Add(this.lblNombre);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.lblDescripcion);
            this.gbProducto.Controls.Add(this.txtStock);
            this.gbProducto.Controls.Add(this.txtNombre);
            this.gbProducto.Location = new System.Drawing.Point(937, 87);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gbProducto.Size = new System.Drawing.Size(421, 410);
            this.gbProducto.TabIndex = 2;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Editar producto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(9, 122);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(100, 119);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(312, 22);
            this.txtMarca.TabIndex = 7;
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.Enabled = false;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(48, 372);
            this.btnGuardarNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarNuevo.TabIndex = 13;
            this.btnGuardarNuevo.Text = "Guardar Nuevo";
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(295, 372);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(295, 336);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(48, 336);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo producto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(100, 149);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(312, 24);
            this.cbTipo.TabIndex = 9;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarVenta.Enabled = false;
            this.btnAgregarVenta.Location = new System.Drawing.Point(1157, 16);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(204, 46);
            this.btnAgregarVenta.TabIndex = 15;
            this.btnAgregarVenta.Text = "AGREGAR A VENTA";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Visible = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.btnTGuardar);
            this.gbTipo.Controls.Add(this.btnTEliminar);
            this.gbTipo.Controls.Add(this.btnTModificar);
            this.gbTipo.Controls.Add(this.btnTNuevo);
            this.gbTipo.Controls.Add(this.lblTNombre);
            this.gbTipo.Controls.Add(this.txtTNombre);
            this.gbTipo.Location = new System.Drawing.Point(937, 586);
            this.gbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Padding = new System.Windows.Forms.Padding(4);
            this.gbTipo.Size = new System.Drawing.Size(421, 158);
            this.gbTipo.TabIndex = 4;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Editar tipo producto";
            // 
            // btnTGuardar
            // 
            this.btnTGuardar.Enabled = false;
            this.btnTGuardar.Location = new System.Drawing.Point(48, 110);
            this.btnTGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTGuardar.Name = "btnTGuardar";
            this.btnTGuardar.Size = new System.Drawing.Size(139, 28);
            this.btnTGuardar.TabIndex = 13;
            this.btnTGuardar.Text = "Guardar tipo";
            this.btnTGuardar.UseVisualStyleBackColor = true;
            this.btnTGuardar.Click += new System.EventHandler(this.btnTGuardar_Click);
            // 
            // btnTEliminar
            // 
            this.btnTEliminar.Enabled = false;
            this.btnTEliminar.Location = new System.Drawing.Point(295, 110);
            this.btnTEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTEliminar.Name = "btnTEliminar";
            this.btnTEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnTEliminar.TabIndex = 15;
            this.btnTEliminar.Text = "Eliminar";
            this.btnTEliminar.UseVisualStyleBackColor = true;
            this.btnTEliminar.Click += new System.EventHandler(this.btnTEliminar_Click);
            // 
            // btnTModificar
            // 
            this.btnTModificar.Enabled = false;
            this.btnTModificar.Location = new System.Drawing.Point(295, 73);
            this.btnTModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTModificar.Name = "btnTModificar";
            this.btnTModificar.Size = new System.Drawing.Size(100, 28);
            this.btnTModificar.TabIndex = 14;
            this.btnTModificar.Text = "Modificar";
            this.btnTModificar.UseVisualStyleBackColor = true;
            this.btnTModificar.Click += new System.EventHandler(this.btnTModificar_Click);
            // 
            // btnTNuevo
            // 
            this.btnTNuevo.Location = new System.Drawing.Point(48, 73);
            this.btnTNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTNuevo.Name = "btnTNuevo";
            this.btnTNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnTNuevo.TabIndex = 12;
            this.btnTNuevo.Text = "Nuevo tipo";
            this.btnTNuevo.UseVisualStyleBackColor = true;
            this.btnTNuevo.Click += new System.EventHandler(this.btnTNuevo_Click);
            // 
            // lblTNombre
            // 
            this.lblTNombre.AutoSize = true;
            this.lblTNombre.Location = new System.Drawing.Point(8, 28);
            this.lblTNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTNombre.Name = "lblTNombre";
            this.lblTNombre.Size = new System.Drawing.Size(58, 17);
            this.lblTNombre.TabIndex = 0;
            this.lblTNombre.Text = "Nombre";
            // 
            // txtTNombre
            // 
            this.txtTNombre.Location = new System.Drawing.Point(100, 25);
            this.txtTNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtTNombre.Name = "txtTNombre";
            this.txtTNombre.Size = new System.Drawing.Size(312, 22);
            this.txtTNombre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblTipos);
            this.panel2.Location = new System.Drawing.Point(16, 586);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 158);
            this.panel2.TabIndex = 4;
            // 
            // tblTipos
            // 
            this.tblTipos.AllowUserToAddRows = false;
            this.tblTipos.AllowUserToDeleteRows = false;
            this.tblTipos.AllowUserToResizeColumns = false;
            this.tblTipos.AllowUserToResizeRows = false;
            this.tblTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tblTipos.Location = new System.Drawing.Point(4, 4);
            this.tblTipos.Margin = new System.Windows.Forms.Padding(4);
            this.tblTipos.MultiSelect = false;
            this.tblTipos.Name = "tblTipos";
            this.tblTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTipos.Size = new System.Drawing.Size(905, 150);
            this.tblTipos.TabIndex = 0;
            this.tblTipos.SelectionChanged += new System.EventHandler(this.tblTipos_SelectionChanged);
            // 
            // gbBusTipo
            // 
            this.gbBusTipo.Controls.Add(this.btnTRest);
            this.gbBusTipo.Controls.Add(this.btnTBuscar);
            this.gbBusTipo.Controls.Add(this.txtBusTNombre);
            this.gbBusTipo.Controls.Add(this.lblBusTNombre);
            this.gbBusTipo.Location = new System.Drawing.Point(16, 510);
            this.gbBusTipo.Margin = new System.Windows.Forms.Padding(4);
            this.gbBusTipo.Name = "gbBusTipo";
            this.gbBusTipo.Padding = new System.Windows.Forms.Padding(4);
            this.gbBusTipo.Size = new System.Drawing.Size(913, 69);
            this.gbBusTipo.TabIndex = 3;
            this.gbBusTipo.TabStop = false;
            this.gbBusTipo.Text = "Buscar tipo producto";
            // 
            // btnTRest
            // 
            this.btnTRest.Location = new System.Drawing.Point(801, 23);
            this.btnTRest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTRest.Name = "btnTRest";
            this.btnTRest.Size = new System.Drawing.Size(100, 28);
            this.btnTRest.TabIndex = 3;
            this.btnTRest.Text = "Reset";
            this.btnTRest.UseVisualStyleBackColor = true;
            this.btnTRest.Click += new System.EventHandler(this.btnTRest_Click);
            // 
            // btnTBuscar
            // 
            this.btnTBuscar.Location = new System.Drawing.Point(693, 23);
            this.btnTBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTBuscar.Name = "btnTBuscar";
            this.btnTBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnTBuscar.TabIndex = 2;
            this.btnTBuscar.Text = "Buscar";
            this.btnTBuscar.UseVisualStyleBackColor = true;
            this.btnTBuscar.Click += new System.EventHandler(this.btnTBuscar_Click);
            // 
            // txtBusTNombre
            // 
            this.txtBusTNombre.Location = new System.Drawing.Point(75, 25);
            this.txtBusTNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusTNombre.Name = "txtBusTNombre";
            this.txtBusTNombre.Size = new System.Drawing.Size(609, 22);
            this.txtBusTNombre.TabIndex = 1;
            // 
            // lblBusTNombre
            // 
            this.lblBusTNombre.AutoSize = true;
            this.lblBusTNombre.Location = new System.Drawing.Point(8, 28);
            this.lblBusTNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusTNombre.Name = "lblBusTNombre";
            this.lblBusTNombre.Size = new System.Drawing.Size(58, 17);
            this.lblBusTNombre.TabIndex = 0;
            this.lblBusTNombre.Text = "Nombre";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.ForeColor = System.Drawing.Color.Red;
            this.lblTipoProducto.Location = new System.Drawing.Point(937, 530);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(244, 29);
            this.lblTipoProducto.TabIndex = 1;
            this.lblTipoProducto.Text = "TIPOS PRODUCTO";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.Red;
            this.lblProductos.Location = new System.Drawing.Point(936, 38);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(176, 29);
            this.lblProductos.TabIndex = 19;
            this.lblProductos.Text = "PRODUCTOS";
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 58;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Stock.Width = 49;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 54;
            // 
            // TipoProducto
            // 
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 751);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.gbBusTipo);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTipos)).EndInit();
            this.gbBusTipo.ResumeLayout(false);
            this.gbBusTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.ComboBox cbBusTipo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.Label lblBusCategoria;
        private System.Windows.Forms.Label lblBusNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Button btnTGuardar;
        private System.Windows.Forms.Button btnTEliminar;
        private System.Windows.Forms.Button btnTModificar;
        private System.Windows.Forms.Button btnTNuevo;
        private System.Windows.Forms.Label lblTNombre;
        private System.Windows.Forms.TextBox txtTNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tblTipos;
        private System.Windows.Forms.GroupBox gbBusTipo;
        private System.Windows.Forms.Button btnTRest;
        private System.Windows.Forms.Button btnTBuscar;
        private System.Windows.Forms.TextBox txtBusTNombre;
        private System.Windows.Forms.Label lblBusTNombre;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}