namespace Presentacion
{
    partial class Clientes
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
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.lblBusNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblClientes
            // 
            this.tblClientes.AllowUserToAddRows = false;
            this.tblClientes.AllowUserToDeleteRows = false;
            this.tblClientes.AllowUserToResizeColumns = false;
            this.tblClientes.AllowUserToResizeRows = false;
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Dni,
            this.Telefono});
            this.tblClientes.Location = new System.Drawing.Point(4, 4);
            this.tblClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tblClientes.MultiSelect = false;
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblClientes.Size = new System.Drawing.Size(905, 398);
            this.tblClientes.TabIndex = 0;
            this.tblClientes.SelectionChanged += new System.EventHandler(this.tblClientes_SelectionChanged);
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
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnReset);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtBusNombre);
            this.gbBuscar.Controls.Add(this.lblBusNombre);
            this.gbBuscar.Location = new System.Drawing.Point(16, 15);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Size = new System.Drawing.Size(913, 69);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar cliente";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(801, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(693, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(75, 25);
            this.txtBusNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(609, 22);
            this.txtBusNombre.TabIndex = 1;
            // 
            // lblBusNombre
            // 
            this.lblBusNombre.AutoSize = true;
            this.lblBusNombre.Location = new System.Drawing.Point(8, 28);
            this.lblBusNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusNombre.Name = "lblBusNombre";
            this.lblBusNombre.Size = new System.Drawing.Size(58, 17);
            this.lblBusNombre.TabIndex = 0;
            this.lblBusNombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblClientes);
            this.panel1.Location = new System.Drawing.Point(16, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 406);
            this.panel1.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(100, 57);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(312, 22);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(100, 89);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(312, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 155);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
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
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(8, 60);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 92);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.lblDni);
            this.gbCliente.Controls.Add(this.txtDni);
            this.gbCliente.Controls.Add(this.btnGuardarNuevo);
            this.gbCliente.Controls.Add(this.btnEliminar);
            this.gbCliente.Controls.Add(this.btnModificar);
            this.gbCliente.Controls.Add(this.btnNuevo);
            this.gbCliente.Controls.Add(this.lblApellidos);
            this.gbCliente.Controls.Add(this.lblDireccion);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.lblTelefono);
            this.gbCliente.Controls.Add(this.txtApellidos);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Location = new System.Drawing.Point(937, 87);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbCliente.Size = new System.Drawing.Size(421, 410);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Editar cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 151);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(312, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 123);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 17);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "Dni";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(100, 119);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(312, 22);
            this.txtDni.TabIndex = 7;
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.Enabled = false;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(44, 234);
            this.btnGuardarNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarNuevo.TabIndex = 11;
            this.btnGuardarNuevo.Text = "Guardar cliente";
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(291, 234);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(291, 198);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(44, 198);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Red;
            this.lblClientes.Location = new System.Drawing.Point(936, 38);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(139, 29);
            this.lblClientes.TabIndex = 19;
            this.lblClientes.Text = "CLIENTES";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarVenta.Enabled = false;
            this.btnAgregarVenta.Location = new System.Drawing.Point(1147, 21);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(204, 46);
            this.btnAgregarVenta.TabIndex = 20;
            this.btnAgregarVenta.Text = "AGREGAR A VENTA";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Visible = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 513);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblClientes;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.Label lblBusNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}