namespace LOGIN_Y_REGISTRO
{
    partial class Recursosform
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
            this.BT_ASIGNACION = new System.Windows.Forms.Button();
            this.BT_MONITOR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txcompu = new System.Windows.Forms.TextBox();
            this.BTACTUALIZAR = new System.Windows.Forms.Button();
            this.BTBORRAR = new System.Windows.Forms.Button();
            this.BTLIMPIAR = new System.Windows.Forms.Button();
            this.combosoft = new System.Windows.Forms.ComboBox();
            this.BTRecuperar = new System.Windows.Forms.Button();
            this.COMPU = new System.Windows.Forms.Label();
            this.SOFTWARE = new System.Windows.Forms.Label();
            this.FECHAFIN = new System.Windows.Forms.Label();
            this.FECHAINICIO = new System.Windows.Forms.Label();
            this.DATEFIN = new System.Windows.Forms.DateTimePicker();
            this.DATEINICIO = new System.Windows.Forms.DateTimePicker();
            this.ALUMNOS = new System.Windows.Forms.Label();
            this.TXTALUMNOS = new System.Windows.Forms.TextBox();
            this.comboarea = new System.Windows.Forms.ComboBox();
            this.combodocente = new System.Windows.Forms.ComboBox();
            this.BTAJUSTES = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ASIGNACION
            // 
            this.BT_ASIGNACION.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_ASIGNACION.Location = new System.Drawing.Point(359, 14);
            this.BT_ASIGNACION.Name = "BT_ASIGNACION";
            this.BT_ASIGNACION.Size = new System.Drawing.Size(126, 23);
            this.BT_ASIGNACION.TabIndex = 2;
            this.BT_ASIGNACION.Text = "PRESENTACION";
            this.BT_ASIGNACION.UseVisualStyleBackColor = true;
            this.BT_ASIGNACION.Click += new System.EventHandler(this.BT_ASIGNACION_Click);
            // 
            // BT_MONITOR
            // 
            this.BT_MONITOR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_MONITOR.Location = new System.Drawing.Point(123, 14);
            this.BT_MONITOR.Name = "BT_MONITOR";
            this.BT_MONITOR.Size = new System.Drawing.Size(108, 23);
            this.BT_MONITOR.TabIndex = 3;
            this.BT_MONITOR.Text = "MONITOREO";
            this.BT_MONITOR.UseVisualStyleBackColor = true;
            this.BT_MONITOR.Click += new System.EventHandler(this.BT_MONITOR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 220);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txcompu
            // 
            this.txcompu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txcompu.Location = new System.Drawing.Point(12, 160);
            this.txcompu.Name = "txcompu";
            this.txcompu.Size = new System.Drawing.Size(161, 20);
            this.txcompu.TabIndex = 7;
            this.txcompu.TextChanged += new System.EventHandler(this.txcompu_TextChanged);
            this.txcompu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txcompu_KeyPress);
            // 
            // BTACTUALIZAR
            // 
            this.BTACTUALIZAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTACTUALIZAR.Location = new System.Drawing.Point(11, 435);
            this.BTACTUALIZAR.Name = "BTACTUALIZAR";
            this.BTACTUALIZAR.Size = new System.Drawing.Size(90, 23);
            this.BTACTUALIZAR.TabIndex = 10;
            this.BTACTUALIZAR.Text = "ACTUALIZAR";
            this.BTACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTACTUALIZAR.Click += new System.EventHandler(this.BTACTUALIZAR_Click);
            // 
            // BTBORRAR
            // 
            this.BTBORRAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTBORRAR.Location = new System.Drawing.Point(489, 435);
            this.BTBORRAR.Name = "BTBORRAR";
            this.BTBORRAR.Size = new System.Drawing.Size(75, 23);
            this.BTBORRAR.TabIndex = 11;
            this.BTBORRAR.Text = "BORRAR";
            this.BTBORRAR.UseVisualStyleBackColor = true;
            this.BTBORRAR.Click += new System.EventHandler(this.BTBORRAR_Click);
            // 
            // BTLIMPIAR
            // 
            this.BTLIMPIAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTLIMPIAR.Location = new System.Drawing.Point(738, 435);
            this.BTLIMPIAR.Name = "BTLIMPIAR";
            this.BTLIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BTLIMPIAR.TabIndex = 12;
            this.BTLIMPIAR.Text = "LIMPIAR";
            this.BTLIMPIAR.UseVisualStyleBackColor = true;
            this.BTLIMPIAR.Click += new System.EventHandler(this.BTLIMPIAR_Click);
            // 
            // combosoft
            // 
            this.combosoft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combosoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosoft.FormattingEnabled = true;
            this.combosoft.Location = new System.Drawing.Point(671, 159);
            this.combosoft.Name = "combosoft";
            this.combosoft.Size = new System.Drawing.Size(140, 21);
            this.combosoft.TabIndex = 13;
            this.combosoft.SelectedIndexChanged += new System.EventHandler(this.combosoft_SelectedIndexChanged);
            // 
            // BTRecuperar
            // 
            this.BTRecuperar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTRecuperar.Location = new System.Drawing.Point(252, 435);
            this.BTRecuperar.Name = "BTRecuperar";
            this.BTRecuperar.Size = new System.Drawing.Size(90, 23);
            this.BTRecuperar.TabIndex = 14;
            this.BTRecuperar.Text = "RECUPERAR";
            this.BTRecuperar.UseVisualStyleBackColor = true;
            this.BTRecuperar.Click += new System.EventHandler(this.BTRecuperar_Click);
            // 
            // COMPU
            // 
            this.COMPU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.COMPU.AutoSize = true;
            this.COMPU.Location = new System.Drawing.Point(9, 141);
            this.COMPU.Name = "COMPU";
            this.COMPU.Size = new System.Drawing.Size(164, 13);
            this.COMPU.TabIndex = 16;
            this.COMPU.Text = "COMPUTADORAS UTILIZADAS";
            // 
            // SOFTWARE
            // 
            this.SOFTWARE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SOFTWARE.AutoSize = true;
            this.SOFTWARE.Location = new System.Drawing.Point(668, 143);
            this.SOFTWARE.Name = "SOFTWARE";
            this.SOFTWARE.Size = new System.Drawing.Size(68, 13);
            this.SOFTWARE.TabIndex = 17;
            this.SOFTWARE.Text = "SOFTWARE";
            this.SOFTWARE.Click += new System.EventHandler(this.SOFTWARE_Click);
            // 
            // FECHAFIN
            // 
            this.FECHAFIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FECHAFIN.AutoSize = true;
            this.FECHAFIN.Location = new System.Drawing.Point(611, 95);
            this.FECHAFIN.Name = "FECHAFIN";
            this.FECHAFIN.Size = new System.Drawing.Size(75, 13);
            this.FECHAFIN.TabIndex = 22;
            this.FECHAFIN.Text = "FECHA FINAL";
            // 
            // FECHAINICIO
            // 
            this.FECHAINICIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FECHAINICIO.AutoSize = true;
            this.FECHAINICIO.Location = new System.Drawing.Point(9, 93);
            this.FECHAINICIO.Name = "FECHAINICIO";
            this.FECHAINICIO.Size = new System.Drawing.Size(82, 13);
            this.FECHAINICIO.TabIndex = 21;
            this.FECHAINICIO.Text = "FECHA INICIAL";
            // 
            // DATEFIN
            // 
            this.DATEFIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DATEFIN.CustomFormat = "MM/dd/yyyy";
            this.DATEFIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATEFIN.Location = new System.Drawing.Point(732, 95);
            this.DATEFIN.Name = "DATEFIN";
            this.DATEFIN.Size = new System.Drawing.Size(80, 20);
            this.DATEFIN.TabIndex = 20;
            this.DATEFIN.Value = new System.DateTime(2023, 2, 9, 21, 23, 16, 0);
            // 
            // DATEINICIO
            // 
            this.DATEINICIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DATEINICIO.CustomFormat = "MM/dd/yyyy";
            this.DATEINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATEINICIO.Location = new System.Drawing.Point(141, 93);
            this.DATEINICIO.Name = "DATEINICIO";
            this.DATEINICIO.Size = new System.Drawing.Size(90, 20);
            this.DATEINICIO.TabIndex = 19;
            this.DATEINICIO.Value = new System.DateTime(2020, 3, 1, 17, 16, 0, 0);
            // 
            // ALUMNOS
            // 
            this.ALUMNOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ALUMNOS.AutoSize = true;
            this.ALUMNOS.Location = new System.Drawing.Point(356, 140);
            this.ALUMNOS.Name = "ALUMNOS";
            this.ALUMNOS.Size = new System.Drawing.Size(129, 13);
            this.ALUMNOS.TabIndex = 24;
            this.ALUMNOS.Text = "NUMERO DE ALUMNOS";
            this.ALUMNOS.Click += new System.EventHandler(this.ALUMNOS_Click);
            // 
            // TXTALUMNOS
            // 
            this.TXTALUMNOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXTALUMNOS.Location = new System.Drawing.Point(359, 159);
            this.TXTALUMNOS.Name = "TXTALUMNOS";
            this.TXTALUMNOS.Size = new System.Drawing.Size(126, 20);
            this.TXTALUMNOS.TabIndex = 23;
            this.TXTALUMNOS.TextChanged += new System.EventHandler(this.TXTALUMNOS_TextChanged);
            this.TXTALUMNOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTALUMNOS_KeyPress);
            // 
            // comboarea
            // 
            this.comboarea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboarea.FormattingEnabled = true;
            this.comboarea.Location = new System.Drawing.Point(12, 54);
            this.comboarea.Name = "comboarea";
            this.comboarea.Size = new System.Drawing.Size(219, 21);
            this.comboarea.TabIndex = 0;
            this.comboarea.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboarea.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // combodocente
            // 
            this.combodocente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combodocente.DropDownWidth = 200;
            this.combodocente.FormattingEnabled = true;
            this.combodocente.Location = new System.Drawing.Point(614, 56);
            this.combodocente.Name = "combodocente";
            this.combodocente.Size = new System.Drawing.Size(198, 21);
            this.combodocente.TabIndex = 1;
            this.combodocente.SelectedIndexChanged += new System.EventHandler(this.combodocente_SelectedIndexChanged);
            this.combodocente.SelectionChangeCommitted += new System.EventHandler(this.combodocente_SelectionChangeCommitted);
            // 
            // BTAJUSTES
            // 
            this.BTAJUSTES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTAJUSTES.Location = new System.Drawing.Point(613, 14);
            this.BTAJUSTES.Name = "BTAJUSTES";
            this.BTAJUSTES.Size = new System.Drawing.Size(106, 23);
            this.BTAJUSTES.TabIndex = 25;
            this.BTAJUSTES.Text = "AJUSTES";
            this.BTAJUSTES.UseVisualStyleBackColor = true;
            this.BTAJUSTES.Click += new System.EventHandler(this.BTAJUSTES_Click);
            // 
            // Recursosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(824, 480);
            this.Controls.Add(this.BTAJUSTES);
            this.Controls.Add(this.ALUMNOS);
            this.Controls.Add(this.TXTALUMNOS);
            this.Controls.Add(this.FECHAFIN);
            this.Controls.Add(this.FECHAINICIO);
            this.Controls.Add(this.DATEFIN);
            this.Controls.Add(this.DATEINICIO);
            this.Controls.Add(this.SOFTWARE);
            this.Controls.Add(this.COMPU);
            this.Controls.Add(this.BTRecuperar);
            this.Controls.Add(this.combosoft);
            this.Controls.Add(this.BTLIMPIAR);
            this.Controls.Add(this.BTBORRAR);
            this.Controls.Add(this.BTACTUALIZAR);
            this.Controls.Add(this.txcompu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_MONITOR);
            this.Controls.Add(this.BT_ASIGNACION);
            this.Controls.Add(this.combodocente);
            this.Controls.Add(this.comboarea);
            this.Name = "Recursosform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECURSOS";
            this.Load += new System.EventHandler(this.Recursosform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_ASIGNACION;
        private System.Windows.Forms.Button BT_MONITOR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txcompu;
        private System.Windows.Forms.Button BTACTUALIZAR;
        private System.Windows.Forms.Button BTBORRAR;
        private System.Windows.Forms.Button BTLIMPIAR;
        private System.Windows.Forms.ComboBox combosoft;
        private System.Windows.Forms.Button BTRecuperar;
        private System.Windows.Forms.Label COMPU;
        private System.Windows.Forms.Label SOFTWARE;
        private System.Windows.Forms.Label FECHAFIN;
        private System.Windows.Forms.Label FECHAINICIO;
        private System.Windows.Forms.DateTimePicker DATEFIN;
        private System.Windows.Forms.DateTimePicker DATEINICIO;
        private System.Windows.Forms.Label ALUMNOS;
        private System.Windows.Forms.TextBox TXTALUMNOS;
        private System.Windows.Forms.ComboBox comboarea;
        private System.Windows.Forms.ComboBox combodocente;
        private System.Windows.Forms.Button BTAJUSTES;
    }
}