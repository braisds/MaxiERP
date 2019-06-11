namespace Presentacion
{
    partial class VentaVer
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
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.Producto,
            this.PrecioUnidad,
            this.Cantidad});
            this.tblProductos.Location = new System.Drawing.Point(4, 4);
            this.tblProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tblProductos.MultiSelect = false;
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductos.Size = new System.Drawing.Size(600, 186);
            this.tblProductos.TabIndex = 0;
            this.tblProductos.SelectionChanged += new System.EventHandler(this.tblProductos_SelectionChanged);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrecioUnidad.HeaderText = "PrecioUnidad";
            this.PrecioUnidad.Name = "PrecioUnidad";
            this.PrecioUnidad.ReadOnly = true;
            this.PrecioUnidad.Width = 122;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 93;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.txtCliente);
            this.gbBuscar.Controls.Add(this.lblCliente);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(16, 103);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuscar.Size = new System.Drawing.Size(604, 74);
            this.gbBuscar.TabIndex = 1;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(115, 26);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(189, 22);
            this.txtCliente.TabIndex = 8;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(8, 30);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(371, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblProductos);
            this.panel1.Location = new System.Drawing.Point(16, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 193);
            this.panel1.TabIndex = 2;
            // 
            // lblNumVenta
            // 
            this.lblNumVenta.AutoSize = true;
            this.lblNumVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVenta.ForeColor = System.Drawing.Color.Red;
            this.lblNumVenta.Location = new System.Drawing.Point(23, 11);
            this.lblNumVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumVenta.Name = "lblNumVenta";
            this.lblNumVenta.Size = new System.Drawing.Size(147, 29);
            this.lblNumVenta.TabIndex = 20;
            this.lblNumVenta.Text = "Num. Venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(456, 11);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 29);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(645, 171);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(645, 364);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(461, 409);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(132, 22);
            this.txtSubTotal.TabIndex = 23;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(383, 412);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(65, 17);
            this.lblSubTotal.TabIndex = 24;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(383, 448);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(52, 17);
            this.lblIva.TabIndex = 26;
            this.lblIva.Text = "Iva (%)";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(461, 444);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(132, 22);
            this.txtIva.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(383, 480);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(461, 476);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 30);
            this.txtTotal.TabIndex = 27;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(312, 545);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 37);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(645, 241);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioUnidad.TabIndex = 30;
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Location = new System.Drawing.Point(642, 218);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(93, 17);
            this.lblPrecioUnidad.TabIndex = 31;
            this.lblPrecioUnidad.Text = "PrecioUnidad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(642, 273);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 33;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(645, 293);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 32;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(645, 322);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // VentaVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 610);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPrecioUnidad);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumVenta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VentaVer";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnModificar;
    }
}