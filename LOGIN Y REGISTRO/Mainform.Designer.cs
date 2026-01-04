namespace LOGIN_Y_REGISTRO
{
    partial class Mainform
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
            this.LOGIN = new System.Windows.Forms.Button();
            this.REGISTRO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.LOGIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LOGIN.Location = new System.Drawing.Point(28, 101);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(109, 80);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // REGISTRO
            // 
            this.REGISTRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.REGISTRO.Location = new System.Drawing.Point(192, 101);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(112, 80);
            this.REGISTRO.TabIndex = 1;
            this.REGISTRO.Text = "REGISTRO";
            this.REGISTRO.UseVisualStyleBackColor = true;
            this.REGISTRO.Click += new System.EventHandler(this.REGISTRO_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.REGISTRO);
            this.Controls.Add(this.LOGIN);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button REGISTRO;
    }
}