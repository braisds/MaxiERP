namespace Presentacion
{
    partial class Usuarios
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
            this.tblUsuarios = new System.Windows.Forms.DataGridView();
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
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarios)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblUsuarios
            // 
            this.tblUsuarios.AllowUserToAddRows = false;
            this.tblUsuarios.AllowUserToDeleteRows = false;
            this.tblUsuarios.AllowUserToResizeColumns = false;
            this.tblUsuarios.AllowUserToResizeRows = false;
            this.tblUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellidos,
            this.Login,
            this.Direccion,
            this.Dni,
            this.Telefono,
            this.Admin});
            this.tblUsuarios.Location = new System.Drawing.Point(4, 4);
            this.tblUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblUsuarios.MultiSelect = false;
            this.tblUsuarios.Name = "tblUsuarios";
            this.tblUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblUsuarios.Size = new System.Drawing.Size(905, 398);
            this.tblUsuarios.TabIndex = 0;
            this.tblUsuarios.SelectionChanged += new System.EventHandler(this.tblUsuarios_SelectionChanged);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnReset);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtBusNombre);
            this.gbBuscar.Controls.Add(this.lblBusNombre);
            this.gbBuscar.Location = new System.Drawing.Point(16, 15);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBuscar.Size = new System.Drawing.Size(913, 69);
            this.gbBuscar.TabIndex = 1;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar usuario";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(801, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(693, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtBusNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(609, 22);
            this.txtBusNombre.TabIndex = 2;
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
            this.panel1.Controls.Add(this.tblUsuarios);
            this.panel1.Location = new System.Drawing.Point(16, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 406);
            this.panel1.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(100, 57);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(312, 22);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(100, 153);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(312, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 219);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 10;
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
            this.lblDireccion.Location = new System.Drawing.Point(8, 156);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.lblPass);
            this.gbUsuario.Controls.Add(this.txtPass);
            this.gbUsuario.Controls.Add(this.lblLogin);
            this.gbUsuario.Controls.Add(this.txtLogin);
            this.gbUsuario.Controls.Add(this.chkAdmin);
            this.gbUsuario.Controls.Add(this.txtTelefono);
            this.gbUsuario.Controls.Add(this.lblDni);
            this.gbUsuario.Controls.Add(this.txtDni);
            this.gbUsuario.Controls.Add(this.btnGuardarNuevo);
            this.gbUsuario.Controls.Add(this.btnEliminar);
            this.gbUsuario.Controls.Add(this.btnModificar);
            this.gbUsuario.Controls.Add(this.btnNuevo);
            this.gbUsuario.Controls.Add(this.lblApellidos);
            this.gbUsuario.Controls.Add(this.lblDireccion);
            this.gbUsuario.Controls.Add(this.lblNombre);
            this.gbUsuario.Controls.Add(this.txtDireccion);
            this.gbUsuario.Controls.Add(this.lblTelefono);
            this.gbUsuario.Controls.Add(this.txtApellidos);
            this.gbUsuario.Controls.Add(this.txtNombre);
            this.gbUsuario.Location = new System.Drawing.Point(937, 87);
            this.gbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUsuario.Size = new System.Drawing.Size(421, 410);
            this.gbUsuario.TabIndex = 2;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Editar usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(8, 124);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(39, 17);
            this.lblPass.TabIndex = 19;
            this.lblPass.Text = "Pass";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(100, 121);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(312, 22);
            this.txtPass.TabIndex = 20;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(8, 92);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 89);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(312, 22);
            this.txtLogin.TabIndex = 17;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(100, 255);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(69, 21);
            this.chkAdmin.TabIndex = 1;
            this.chkAdmin.Text = "Admin";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 215);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(312, 22);
            this.txtTelefono.TabIndex = 16;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 187);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 17);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "Dni";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(100, 183);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(312, 22);
            this.txtDni.TabIndex = 7;
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.Enabled = false;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(43, 322);
            this.btnGuardarNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnGuardarNuevo.TabIndex = 13;
            this.btnGuardarNuevo.Text = "Guardar usuario";
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(289, 322);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnModificar.Location = new System.Drawing.Point(289, 287);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(43, 287);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 28);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo usuario";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarios.Location = new System.Drawing.Point(936, 38);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(144, 29);
            this.lblUsuarios.TabIndex = 19;
            this.lblUsuarios.Text = "USUARIOS";
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
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // Admin
            // 
            this.Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            this.Admin.Width = 53;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 513);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarios)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblUsuarios;
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
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
    }
}