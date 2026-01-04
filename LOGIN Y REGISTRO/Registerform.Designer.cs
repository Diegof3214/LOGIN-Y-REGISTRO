namespace LOGIN_Y_REGISTRO
{
    partial class Registerform
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
            this.Btcancelar = new System.Windows.Forms.Button();
            this.BTCrear = new System.Windows.Forms.Button();
            this.Txtcontraseña = new System.Windows.Forms.TextBox();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.Label();
            this.Confirmacion = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btcancelar
            // 
            this.Btcancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btcancelar.Location = new System.Drawing.Point(162, 260);
            this.Btcancelar.Name = "Btcancelar";
            this.Btcancelar.Size = new System.Drawing.Size(75, 23);
            this.Btcancelar.TabIndex = 11;
            this.Btcancelar.Text = "Cancelar";
            this.Btcancelar.UseVisualStyleBackColor = true;
            this.Btcancelar.UseWaitCursor = true;
            this.Btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // BTCrear
            // 
            this.BTCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTCrear.Location = new System.Drawing.Point(16, 260);
            this.BTCrear.Name = "BTCrear";
            this.BTCrear.Size = new System.Drawing.Size(75, 23);
            this.BTCrear.TabIndex = 10;
            this.BTCrear.Text = "Crear";
            this.BTCrear.UseVisualStyleBackColor = true;
            this.BTCrear.UseWaitCursor = true;
            this.BTCrear.Click += new System.EventHandler(this.BTCrear_Click);
            // 
            // Txtcontraseña
            // 
            this.Txtcontraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txtcontraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Txtcontraseña.Location = new System.Drawing.Point(97, 157);
            this.Txtcontraseña.Name = "Txtcontraseña";
            this.Txtcontraseña.Size = new System.Drawing.Size(140, 20);
            this.Txtcontraseña.TabIndex = 9;
            this.Txtcontraseña.UseSystemPasswordChar = true;
            this.Txtcontraseña.UseWaitCursor = true;
            this.Txtcontraseña.TextChanged += new System.EventHandler(this.Txtcontraseña_TextChanged);
            // 
            // Txtusuario
            // 
            this.Txtusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txtusuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Txtusuario.Location = new System.Drawing.Point(97, 129);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(140, 20);
            this.Txtusuario.TabIndex = 8;
            this.Txtusuario.UseWaitCursor = true;
            this.Txtusuario.TextChanged += new System.EventHandler(this.Txtusuario_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(12, 157);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 7;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.UseWaitCursor = true;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(12, 129);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 6;
            this.Usuario.Text = "Usuario";
            this.Usuario.UseWaitCursor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApellidos.Location = new System.Drawing.Point(97, 77);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(140, 20);
            this.txtApellidos.TabIndex = 12;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombres.Location = new System.Drawing.Point(97, 51);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(140, 20);
            this.txtNombres.TabIndex = 13;
            this.txtNombres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtconfirmacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtconfirmacion.Location = new System.Drawing.Point(97, 187);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.Size = new System.Drawing.Size(140, 20);
            this.txtconfirmacion.TabIndex = 14;
            this.txtconfirmacion.UseSystemPasswordChar = true;
            this.txtconfirmacion.TextChanged += new System.EventHandler(this.txtconfirmacion_TextChanged);
            // 
            // Nombres
            // 
            this.Nombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(13, 51);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(49, 13);
            this.Nombres.TabIndex = 15;
            this.Nombres.Text = "Nombres";
            this.Nombres.Click += new System.EventHandler(this.label1_Click);
            // 
            // Apellidos
            // 
            this.Apellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Apellidos.AutoSize = true;
            this.Apellidos.Location = new System.Drawing.Point(12, 77);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(49, 13);
            this.Apellidos.TabIndex = 16;
            this.Apellidos.Text = "Apellidos";
            // 
            // Confirmacion
            // 
            this.Confirmacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Confirmacion.AutoSize = true;
            this.Confirmacion.Location = new System.Drawing.Point(12, 187);
            this.Confirmacion.Name = "Confirmacion";
            this.Confirmacion.Size = new System.Drawing.Size(68, 13);
            this.Confirmacion.TabIndex = 17;
            this.Confirmacion.Text = "Confirmacion";
            this.Confirmacion.Click += new System.EventHandler(this.Confirmacion_Click);
            // 
            // Correo
            // 
            this.Correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Correo.AutoSize = true;
            this.Correo.Location = new System.Drawing.Point(12, 103);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(38, 13);
            this.Correo.TabIndex = 19;
            this.Correo.Text = "Correo";
            this.Correo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcorreo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcorreo.Location = new System.Drawing.Point(97, 103);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(140, 20);
            this.txtcorreo.TabIndex = 18;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 306);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.Confirmacion);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.Btcancelar);
            this.Controls.Add(this.BTCrear);
            this.Controls.Add(this.Txtcontraseña);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Name = "Registerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.Registerform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btcancelar;
        private System.Windows.Forms.Button BTCrear;
        private System.Windows.Forms.TextBox Txtcontraseña;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.Label Confirmacion;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.TextBox txtcorreo;
    }
}