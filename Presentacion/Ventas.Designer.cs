namespace Presentacion
{
    partial class Ventas
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
            this.tblVentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.lblNumVenta = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.lblBusNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblVentas)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblVentas
            // 
            this.tblVentas.AllowUserToAddRows = false;
            this.tblVentas.AllowUserToDeleteRows = false;
            this.tblVentas.AllowUserToResizeColumns = false;
            this.tblVentas.AllowUserToResizeRows = false;
            this.tblVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NumVenta,
            this.Cliente,
            this.Fecha});
            this.tblVentas.Location = new System.Drawing.Point(4, 4);
            this.tblVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tblVentas.MultiSelect = false;
            this.tblVentas.Name = "tblVentas";
            this.tblVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblVentas.Size = new System.Drawing.Size(905, 398);
            this.tblVentas.TabIndex = 0;
            this.tblVentas.SelectionChanged += new System.EventHandler(this.tblVentas_SelectionChanged);
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
            // NumVenta
            // 
            this.NumVenta.HeaderText = "NumVenta";
            this.NumVenta.Name = "NumVenta";
            this.NumVenta.ReadOnly = true;
            this.NumVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.txtNumVenta);
            this.gbBuscar.Controls.Add(this.lblNumVenta);
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
            this.gbBuscar.Text = "Buscar venta";
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Location = new System.Drawing.Point(115, 26);
            this.txtNumVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.Size = new System.Drawing.Size(189, 22);
            this.txtNumVenta.TabIndex = 1;
            // 
            // lblNumVenta
            // 
            this.lblNumVenta.AutoSize = true;
            this.lblNumVenta.Location = new System.Drawing.Point(8, 30);
            this.lblNumVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumVenta.Name = "lblNumVenta";
            this.lblNumVenta.Size = new System.Drawing.Size(74, 17);
            this.lblNumVenta.TabIndex = 0;
            this.lblNumVenta.Text = "NumVenta";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(776, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(668, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(425, 26);
            this.txtBusNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(189, 22);
            this.txtBusNombre.TabIndex = 3;
            // 
            // lblBusNombre
            // 
            this.lblBusNombre.AutoSize = true;
            this.lblBusNombre.Location = new System.Drawing.Point(313, 30);
            this.lblBusNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusNombre.Name = "lblBusNombre";
            this.lblBusNombre.Size = new System.Drawing.Size(103, 17);
            this.lblBusNombre.TabIndex = 2;
            this.lblBusNombre.Text = "Nombre cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblVentas);
            this.panel1.Location = new System.Drawing.Point(16, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 412);
            this.panel1.TabIndex = 2;
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.btnVer);
            this.gbVenta.Controls.Add(this.btnNuevo);
            this.gbVenta.Location = new System.Drawing.Point(937, 112);
            this.gbVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Padding = new System.Windows.Forms.Padding(4);
            this.gbVenta.Size = new System.Drawing.Size(201, 392);
            this.gbVenta.TabIndex = 1;
            this.gbVenta.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(33, 59);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(139, 28);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Abrir venta";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(33, 23);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nueva venta";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.Red;
            this.lblVentas.Location = new System.Drawing.Point(936, 38);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(92, 29);
            this.lblVentas.TabIndex = 19;
            this.lblVentas.Text = "Ventas";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 513);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.gbVenta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblVentas)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbVenta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblVentas;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.Label lblBusNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.Label lblNumVenta;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}