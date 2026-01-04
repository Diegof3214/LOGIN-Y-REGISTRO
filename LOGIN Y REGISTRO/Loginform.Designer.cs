namespace LOGIN_Y_REGISTRO
{
    partial class Loginform
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
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtcontraseña = new System.Windows.Forms.TextBox();
            this.BTIniciar = new System.Windows.Forms.Button();
            this.Btcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(28, 30);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            this.Usuario.UseWaitCursor = true;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(28, 90);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 1;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.UseWaitCursor = true;
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(98, 30);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(100, 20);
            this.Txtusuario.TabIndex = 2;
            this.Txtusuario.UseWaitCursor = true;
            this.Txtusuario.TextChanged += new System.EventHandler(this.Txtusuario_TextChanged);
            // 
            // Txtcontraseña
            // 
            this.Txtcontraseña.Location = new System.Drawing.Point(98, 90);
            this.Txtcontraseña.Name = "Txtcontraseña";
            this.Txtcontraseña.PasswordChar = '*';
            this.Txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.Txtcontraseña.TabIndex = 3;
            this.Txtcontraseña.UseWaitCursor = true;
            // 
            // BTIniciar
            // 
            this.BTIniciar.Location = new System.Drawing.Point(31, 154);
            this.BTIniciar.Name = "BTIniciar";
            this.BTIniciar.Size = new System.Drawing.Size(75, 23);
            this.BTIniciar.TabIndex = 4;
            this.BTIniciar.Text = "Iniciar";
            this.BTIniciar.UseVisualStyleBackColor = true;
            this.BTIniciar.UseWaitCursor = true;
            this.BTIniciar.Click += new System.EventHandler(this.BTIniciar_Click);
            // 
            // Btcancelar
            // 
            this.Btcancelar.Location = new System.Drawing.Point(153, 153);
            this.Btcancelar.Name = "Btcancelar";
            this.Btcancelar.Size = new System.Drawing.Size(75, 23);
            this.Btcancelar.TabIndex = 5;
            this.Btcancelar.Text = "Cancelar";
            this.Btcancelar.UseVisualStyleBackColor = true;
            this.Btcancelar.UseWaitCursor = true;
            this.Btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 200);
            this.Controls.Add(this.Btcancelar);
            this.Controls.Add(this.BTIniciar);
            this.Controls.Add(this.Txtcontraseña);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox Txtcontraseña;
        private System.Windows.Forms.Button BTIniciar;
        private System.Windows.Forms.Button Btcancelar;
    }
}